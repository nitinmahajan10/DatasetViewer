mainCtrl.factory("dataSetSvc", ["$http", function ($http) {
    var dataSetSvc = {
        "getDataSet": function (numOfTables, numOfCol) {
            return $http({ method: "get", url: "Api/Dataset/GetDataset?numOfTables=" + numOfTables + "&numOfCol=" + numOfCol })
        }
    };
    return dataSetSvc;
}]);