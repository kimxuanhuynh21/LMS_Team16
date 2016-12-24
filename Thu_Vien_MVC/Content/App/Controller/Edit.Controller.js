(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('EditPhieuTraCtrl', EditPhieuTraCtrl);

    EditPhieuTraCtrl.$inject = ['$scope', '$http', '$filter'];

    function EditPhieuTraCtrl($scope, $http, $filter) {

        var maphieutra = document.getElementById("MaPhieuTra").value;
        var mathedocgia = document.getElementById("DocGia_MaThe").value;

        var list_cuonsach = [];

        $scope.list_sachchuatra = [];

        $scope.list_sachphieutra = [];

        $scope.list_sachdachon = [];

        function get_sachdocgia() {
            var obj_initialize = { ID: '-1', Name: '---Null---' };
            list_cuonsach.push(obj_initialize);
            $scope.CuonSach = {
                availableOptions: list_cuonsach,
                selectedOption: { ID: '-1' } //This sets the default value of the select in the ui
            };
        }


        $http({
            method: "post",
            url: "/DanhSachPhieuTra/getSachPhieuTra",
            data: { 'maphieutra': maphieutra },
            dataType: "json",
        })
                .success(function (result) {
                    //display message
                    if (result == "error") {
                        alert("Ma the khong ton tai");
                    }
                    else {
                        $scope.list_sachphieutra = result;

                    }
                });



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


        $scope.removeChiTietTra = function (id) {

            var s = confirm("Ban co thuc su muon xoa...!!!");
            if (s == true) {
                $http({
                    method: "post",
                    url: "/DanhSachPhieuTra/deleteChiTietTra",
                    data: { 'id': id, 'mathe': mathedocgia },
                    dataType: "json",
                })
                .success(function (result) {
                    //display message
                    if (result == "error") {
                        alert("Ma the khong ton tai");
                    }
                    else {
                    }
                });
            }
        };


        $scope.show_add = function () {
            $scope.show_combobox = true;
            $scope.show_tabletemp = true;
            $scope.btn_submit = true;

            get_sachdocgia();

            $http({
                method: "post",
                url: "/DanhSachPhieuTra/getSachChuaTra",
                data: { 'id': mathedocgia },
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

                        $scope.list_sachchuatra = result;

                    }
                });



        }


        $scope.change_cuonsach = function (mavach) {
            if (mavach != -1) {

                var d = 0;
                angular.forEach($scope.list_sachdachon, function (value, key) {
                    if (value.MaVach == mavach) {
                        d++;
                    }
                });
                if (d == 0) {
                    angular.forEach($scope.list_sachchuatra, function (value, key) {
                        if (value.MaVach == mavach) {
                            $scope.list_sachdachon.push(value);
                        }
                    });
                }

            }
        };

        $scope.removeCuonSach = function (mavach) {
            if (mavach != -1) {
                angular.forEach($scope.list_sachdachon, function (value, key) {
                    if (value.MaVach == mavach) {
                        $scope.list_sachdachon.splice(key, 1);
                    }
                });
            }
        };

        $scope.post_Edit = function () {
            var s = "";
            angular.forEach($scope.list_sachdachon, function (value, key) {
                s = s + value.MaVach + ",";
            });

            if (s != "") {
                $http({
                    method: "post",
                    url: "/DanhSachPhieuTra/Post_EditChiTietTra",
                    data: { 'sMaVach': s, 'MaPhieuTra': maphieutra },
                    dataType: "json",
                })
                .success(function (result) {
                    //display message
                    if (result == "error") {
                        //...
                    }
                    else {
                        //...
                        window.location.href = "/DanhSachPhieuTra/Index";
                    }
                });
            }

        }

    };
})();



