function datatableViewerCtrlr() {
    this.columns = [];
    this.gridOptions = {
        enableSorting: true,
        enableFiltering: true,
        columnDefs: this.columns,
        onRegisterApi: function (gridApi) {
            this.gridApi = gridApi;
        }
    };
    this.$onChanges = function (changesObj) {
        console.log('data changed');
        this.showDataTable(this.info);
    };

    this.showDataTable = function (dataTable) {
        this.columns.length = 0;

        if (this.info === undefined || this.info === null || this.info.lenght == 0) return;

        angular.forEach(this.info[0], function (value, key) {
            this.push({ field: key });
        }, this.columns);

        this.gridOptions.data = this.info;
    }
}

myApp.component("datatableViewer", {
    restrict: "E",
    template: "<div ui-grid='$ctrl.gridOptions'></div>",
    controller: datatableViewerCtrlr,
    bindings: {
        info: "<"
    }
});