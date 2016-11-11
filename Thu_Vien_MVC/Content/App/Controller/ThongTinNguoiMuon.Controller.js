(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinNguoiMuonCtrl', ThongTinNguoiMuonCtrl);

    ThongTinNguoiMuonCtrl.$inject = ['$scope'];

    function ThongTinNguoiMuonCtrl($scope) {
        $scope.test = "Xuân";

        
    }
})();