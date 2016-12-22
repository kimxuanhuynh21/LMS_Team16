

(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('TraSachCtrl', TraSachCtrl);

    TraSachCtrl.$inject = ['$scope', '$http', '$filter'];

    function TraSachCtrl($scope, $http, $filter) {


        var list_cuonsach = [];

        function get_sachdocgia() {
            var obj_initialize = { ID: '-1', Name: '---Chọn Cuon Sach---' };
            list_cuonsach.push(obj_initialize);
            $scope.CuonSach = {
                availableOptions: list_cuonsach,
                selectedOption: { ID: '-1' } //This sets the default value of the select in the ui
            };
        }
        get_sachdocgia();
    };



})();



