(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinNguoiTraCtrl', ThongTinNguoiTraCtrl);

    ThongTinNguoiTraCtrl.$inject = ['$scope', '$http'];

    function ThongTinNguoiTraCtrl($scope, $http) {
        $scope.panelPhieuTraShow = false;
        $scope.dsSachTraShow = true;
        $scope.dsSachTra = [];
        $scope.dsCuonSach = [];
        $scope.phieuTraShow = false;
        $scope.maTheDocGia;

        //function
        $scope.displayDate = displayDate;
        $scope.themCuonSachTra = themCuonSachTra;
        $scope.removeCuonSach = removeCuonSach;
        $scope.detailPhieuTra = detailPhieuTra;
        $scope.getDsCuonSach = getDsCuonSach;
        $scope.nhapDocGia = nhapDocGia;

        function themCuonSachTra(cuonSachTra) {
            if (!cuonSachTra) {
                return;
            }
            var flag = false;
            if (cuonSachTra) {
                $scope.dsSachTra.forEach(function (item) {
                    if (item.MaVach.toLowerCase() == cuonSachTra.MaVach.toLowerCase()) {
                        flag = true;
                        return;
                    }
                });
            }
            if (flag == false) {
                $scope.dsSachTra.push(cuonSachTra);
            }
            else {
                alert('Cuốn sách bạn chọn bị trùng');
            }
        }

        //Hàm xóa cuốn sách được chọn
        function removeCuonSach(maVach) {
            $scope.dsSachTra.forEach(function (item, index) {
                if (item.MaVach == maVach) {
                    $scope.dsSachTra.splice(index, 1);
                    return;
                }
            });
        }

        function detailPhieuTra() {
            var requestData = {
                MaThe: $scope.maTheDocGia,
                dsChiTietMuon: $scope.dsSachTra
            };
            $http
                .post('/PhieuTra/ChiTietPhieuTra', requestData)
                .then(function successCallback(response) {
                    if (response.data != "") {
                        $scope.phieuTra = response.data;
                        $scope.dsSachTraShow = false;
                        $scope.phieuTraShow = true;
                        window.onbeforeunload = function () { };
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
        }

        //Hàm convert dd-mm-yyyy
        function displayDate(date) {
            if (date) {
                var dateInMilisecond = parseInt(date.replace("/Date(", "").replace(")/", ""));
                var convertedDate = new Date(dateInMilisecond);
                var month = convertedDate.getMonth() + 1;
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

        function getDsCuonSach() {
            $http
                .get('/AngularAPI/dsCuonSachDaMuon?maTheDocGia=' + $scope.maTheDocGia)
                .then(function successCallback(response) {
                    $scope.dsCuonSach = response.data;
                }, function errorCallback(error) {
                    console.log(error);
                });
        }

        function nhapDocGia(maTheDocGia) {
            $scope.getDsCuonSach();
        }

        //Alert when user attempt to leave or reload this page
        window.onbeforeunload = function () {
            return "Data will be lost if you leave the page, are you sure?";
        };
    }
})();