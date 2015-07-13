(function () {//module starts
    "use strict";

    var locationModel = function (locationJS) {
        var self = this;

        self.Locations = ko.mapping.fromJS(locationJS);

        self.SurfaceStations = ko.computed(function () {
            return ko.utils.arrayFilter(self.Locations(), function (location) {
                return location.LocationType() == surfaceWaterQualityTypeValue;
            });
        });//end of SurfaceStations
    }//end of locationModel

    $(document).ready(function () {
        $.ajax({
            url: Hatfield.RootURL + "../api/QueryDataAPI/GetLocations", //Hatfield is a global variable define in the layout page
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: 'application/json',
            success: function (data) {
                var locationJson = data;
                stationData = data;
                locationViewModel = new locationModel(locationJson);
                ko.applyBindings(locationViewModel);
            },
            error: function (data) {
                alert("Get Location data fail");
            }
        });
    });//end of document ready
}());         