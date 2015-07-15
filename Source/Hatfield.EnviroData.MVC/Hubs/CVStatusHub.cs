using Hatfield.EnviroData.Core;
using Hatfield.EnviroData.CVUpdater;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hatfield.EnviroData.MVC.Hubs
{
    public class CVStatusHub: Hub
    {
        public void Send(string name, string message)
        {
            string ApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            string VocabSiteUrl = ConfigurationManager.AppSettings["VocabTermsUrl"];

            CVTermAPILayer parser = new CVTermAPILayer();
            CVTermBusinessLayer biz = new CVTermBusinessLayer(new ODM2Entities());

            var endpoints = parser.GetAPIEndpoints(VocabSiteUrl);

            //Get data for each CV Type, extract and write to the DB
            foreach (var endpoint in endpoints)
            {
                var doc = new XDocument();
                var rawCV = parser.GetSingleCV(ApiUrl, endpoint.Value, "skos");
                var results = parser.ImportXMLData(XDocument.Parse(rawCV));
                var addResults = biz.AddOrUpdateCVs(endpoint.Value, results.ExtractedEntities);
                var deletedResults = biz.CheckForDeleted(endpoint.Value, results.ExtractedEntities);

            }
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}