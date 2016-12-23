(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('SuaPhieuMuonCtrl', SuaPhieuMuonCtrl);

    SuaPhieuMuonCtrl.$inject = ['$scope', '$http', '$filter'];

    function SuaPhieuMuonCtrl($scope, $http, $filter) {
        $scope.PhieuMuonId;
        $scope.soLuongMuonToiDa = 0;
        $scope.dsCuonSach = [];
        $scope.dsCuonSachMuon = [];
        $scope.xoaChiTietPhieuMuon = xoaChiTietPhieuMuon;

        $scope.displayDate = displayDate;
        $scope.themCuonSachMuon = themCuonSachMuon
        $scope.getDsChiTietMuon = getDsChiTietMuon;

        getDsCuonSach();

        function getDsCuonSach() {
            $http
                .get('/AngularAPI/dsCuonSach')
                .then(function successCallback(response) {
                    $scope.dsCuonSach = response.data;
                }, function errorCallback(error) {
                    console.log(error);
                });
        }

        function getDsChiTietMuon(PhieuMuonId) {
            $http
                .get('/AngularAPI/dsChiTietMuon?PhieuMuonId=' + PhieuMuonId)
                .then(function successCallback(response) {
                    if (response.data !== '') {
                        $scope.dsCuonSachMuon = response.data;
                        $scope.soLuongMuonToiDa = $scope.dsCuonSachMuon.length + $scope.dsCuonSachMuon[0].SoSachConLai;
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
        }

        function themCuonSachMuon(cuonSachMuon) {
            if ($scope.dsCuonSachMuon.length === $scope.soLuongMuonToiDa) {
                alert('Độc giả đã mượn đủ số sách quy định');
                return;
            }
            var flag = false;
            if (cuonSachMuon) {
                $scope.dsCuonSachMuon.forEach(function (item) {
                    if (item.MaVach.toLowerCase() == cuonSachMuon.MaVach.toLowerCase()) {
                        if (item.isDeleted == false) {
                            flag = true;
                        }
                        else {
                            cuonSachMuon = item;
                        }
                        return;
                    }
                });
            }
            if (flag == false) {
                if (cuonSachMuon.isDeleted == true) {
                    cuonSachMuon.isDeleted = false;
                }
                else {
                    cuonSachMuon.isDeleted = false;
                    $scope.dsCuonSachMuon.push(cuonSachMuon);
                }
            }
            else {
                alert('Cuốn sách bạn chọn bị trùng');
            }
        }

        function xoaChiTietPhieuMuon(cuonSachMuon) {
            cuonSachMuon.isDeleted = true;
        }

        //Hàm convert dd-mm-yyyy
        function displayDate(date) {
            if (date) {
                //var dateInMilisecond = parseInt(date.replace("/Date(", "").replace(")/", ""));
                var convertedDate = new Date(date);
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

    };



})();