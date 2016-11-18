(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinNguoiMuonCtrl', ThongTinNguoiMuonCtrl);

    ThongTinNguoiMuonCtrl.$inject = ['$scope', '$http'];

    function ThongTinNguoiMuonCtrl($scope, $http) {
        $scope.maTheDocGia;
        $scope.docGiaInfo;
        $scope.lichSuMuon = [];
        $scope.panelDocGiaShow = false;

        $scope.togglePanelDocGia = togglePanelDocGia;
        $scope.displayDate = displayDate;

        function togglePanelDocGia() {
            $http
                .get('/PhieuMuon/DocGia/?maThe=' + $scope.maTheDocGia)
                .then(function successCallback(response) {
                    if (response.data != "") {
                        $scope.panelDocGiaShow = true;
                        $scope.docGiaInfo = response.data;
                    }
                    else {
                        $scope.panelDocGiaShow = false;
                        alert('Không tìm thấy mã thẻ độc giả');
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });

            $http
                .get('/PhieuMuon/LichSuMuon/?maThe=' + $scope.maTheDocGia)
                .then(function successCallback(response) {
                    if (response.data != "") {
                        $scope.lichSuMuon = response.data;
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
        }

        function displayDate(date) {
            if (date) {
                var dateInMilisecond = parseInt(date.replace("/Date(", "").replace(")/", ""));
                var convertedDate = new Date(dateInMilisecond);
                var month = convertedDate.getMonth();
                var date = convertedDate.getDate();
                if (month < 10) {
                    month = '0' + month;
                }
                if (date < 10) {
                    date = '0' + date;
                }
                return date + "-" + month + "-" + convertedDate.getFullYear();
            }
        }
    }
})();