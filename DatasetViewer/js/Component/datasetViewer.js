function datasetViewerCtrlr() {
}

myApp.component("datasetViewer", {
    restrict: "E",
    template: "<div ng-repeat='(key, value) in $ctrl.info'><datatable-viewer info='value'></datatable-viewer></div>",
    controller: datasetViewerCtrlr,
    bindings: {
        info: "<"
    }
});