

(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('TraSachCtrl', TraSachCtrl);

    TraSachCtrl.$inject = ['$scope', '$http', '$filter'];

    function TraSachCtrl($scope, $http, $filter) {

        $scope.listCuonSach = [];
        $scope.listSachTra = [];
        var list_cuonsach = [];
        get_sachdocgia();


        function get_sachdocgia() {
            var obj_initialize = { ID: '-1', Name: '---Null---' };
            list_cuonsach.push(obj_initialize);
            $scope.CuonSach = {
                availableOptions: list_cuonsach,
                selectedOption: { ID: '-1' } //This sets the default value of the select in the ui
            };
        }

        $scope.nhapDocGia = function (id) {

            id = id.toUpperCase();

            $http({
                method: "post",
                url: "/PhieuTra/getDocGia",
                data: { ID: id },
                dataType: "json",
            })
                .success(function (result) {
                    //display message
                    if (result == "error") {
                        alert("Ma the khong ton tai");
                    }
                    else {
                        list_cuonsach = [];
                        angular.forEach(result, function (value, key) {
                            var obj_initialize = { ID: value.MaVach, Name: value.MaVach };
                            list_cuonsach.push(obj_initialize);
                        });
                        var obj_initialize = { ID: '-1', Name: '---Chon Ma Vach---' };
                        list_cuonsach.push(obj_initialize);
                        $scope.CuonSach = {
                            availableOptions: list_cuonsach,
                            selectedOption: { ID: '-1' } //This sets the default value of the select in the ui
                        };

                        $scope.listCuonSach = result;
                    }
                });
        }

        //Hàm convert dd-mm-yyyy
        $scope.displayDate = function (date) {
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

        $scope.change_cuonsach = function (mavach) {
            if (mavach != -1) {
                angular.forEach($scope.listCuonSach, function (value, key) {
                    if (value.MaVach == mavach) {
                        $scope.listSachTra.push(value);
                    }
                });
            }
        };

        $scope.removeCuonSach = function (mavach) {
            if (mavach != -1) {
                angular.forEach($scope.listCuonSach, function (value, key) {
                    if (value.MaVach == mavach) {
                        $scope.listSachTra.splice(key, 1);
                    }
                });
            }
        };

        $scope.detailPhieuTra = function (mathe) {

            var s = "";
            angular.forEach($scope.listSachTra, function (value, key) {
                s = s + value.MaVach + ",";
            });

            if (s != "" && mathe != "") {
                $http({
                    method: "post",
                    url: "/PhieuTra/submitTraSach",
                    data: { 'sMaVach': s, 'MaThe': mathe },
                    dataType: "json",
                })
                .success(function (result) {
                    //display message
                    if (result == "error") {
                        //...
                    }
                    else {
                        //...
                    }
                });
            }
        }

    };
})();



