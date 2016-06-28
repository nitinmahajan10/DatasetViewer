var myApp = angular.module("myApp", ["ui.grid"]);

var mainCtrl = myApp.controller("mainCtrl", ["$scope", "dataSetSvc", function ($scope, dataSetSvc) {
    $scope.dataset = { };

    $scope.onInit = function () {
        $scope.refreshData();
    };

    $scope.refreshData = function () {
        $scope.dataset = {};
        dataSetSvc.getDataSet(3, 5).then(function (result) {
            $scope.dataset = result.data;
        });
    };    
}]);
