(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinNguoiTraCtrl', ThongTinNguoiTraCtrl);

    ThongTinNguoiTraCtrl.$inject = ['$scope', '$http', '$filter'];

    function ThongTinNguoiTraCtrl($scope, $http, $filter) {
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
        console.log(list_cuonsach);


        //$scope.maPhieuMuon;
        //$scope.phieuMuonInfo;
        //$scope.panelPhieuTraShow = false;
        //var phieuMuonFlag = false;
        //$scope.dsSachTraShow = true;
        //$scope.phieuMuonShow = false;
        //$scope.dsSachTra = [];
        //$scope.dsCuonSach = [];
        //$scope.phieuTraShow = false;
        //$scope.maTheDocGia;

        ////function
        //$scope.togglePanelPhieuMuon = togglePanelPhieuMuon;
        //$scope.displayDate = displayDate;
        //$scope.submitPhieuMuonInfo = submitPhieuMuonInfo;
        //$scope.themCuonSachTra = themCuonSachTra;
        //$scope.removeCuonSach = removeCuonSach;
        //$scope.detailPhieuTra = detailPhieuTra;
        //$scope.getDsCuonSach = getDsCuonSach;
        //$scope.nhapDocGia = nhapDocGia;

        //function togglePanelPhieuMuon() {
        //    $http
        //        .get('/PhieuTra/PhieuMuon/?maPhieuMuon=' + $scope.maPhieuMuon)
        //        .then(function successCallback(response) {
        //            if (response.data != "") {
        //                $scope.panelPhieuTraShow = true;
        //                $scope.phieuMuonInfo = response.data;
        //                phieuMuonFlag = true;
        //            }
        //            else {
        //                alert('Không tìm thấy phiếu mượn');
        //                phieuMuonFlag = false;
        //            }
        //        },
        //        function errorCallback(error) {
        //            console.log(error);
        //        });
        //}

        //function submitPhieuMuonInfo() {
        //    if (phieuMuonFlag == false) {
        //        alert('Bạn chưa chọn phiếu mượn');
        //    }
        //    else {
        //        $scope.phieuMuonShow = false;
        //        $scope.dsSachTraShow = true;
        //    }
        //}

        //function themCuonSachTra(cuonSachTra) {
        //    var flag = false;
        //    if (cuonSachTra) {
        //        $scope.dsSachTra.forEach(function (item) {
        //            if (item.MaVach.toLowerCase() == cuonSachTra.MaVach.toLowerCase()) {
        //                flag = true;
        //                return;
        //            }
        //        });
        //    }
        //    if (flag == false) {
        //        $scope.dsSachTra.push(cuonSachTra);
        //    }
        //    else {
        //        alert('Cuốn sách bạn chọn bị trùng');
        //    }
        //}

        ////Hàm xóa cuốn sách được chọn
        //function removeCuonSach(maVach) {
        //    $scope.dsSachTra.forEach(function (item, index) {
        //        if (item.MaVach == maVach) {
        //            $scope.dsSachTra.splice(index, 1);
        //            return;
        //        }
        //    });
        //}

        //function detailPhieuTra() {
        //    var requestData = {
        //        phieuMuon: $scope.phieuMuonInfo,
        //        dsChiTietMuon: $scope.dsSachTra
        //    };
        //    $http
        //        .post('/PhieuTra/ChiTietPhieuTra', requestData)
        //        .then(function successCallback(response) {
        //            if (response.data != "") {
        //                $scope.phieuTra = response.data;
        //                $scope.dsSachTraShow = false;
        //                $scope.phieuTraShow = true;
        //                window.onbeforeunload = function () { };
        //            }
        //        }, function errorCallback(error) {
        //            console.log(error);
        //        });
        //}

        ////Hàm convert dd-mm-yyyy
        //function displayDate(date) {
        //    if (date) {
        //        var dateInMilisecond = parseInt(date.replace("/Date(", "").replace(")/", ""));
        //        var convertedDate = new Date(dateInMilisecond);
        //        var month = convertedDate.getMonth() + 1;
        //        var date = convertedDate.getDate();
        //        if (month < 10) {
        //            month = '0' + month;
        //        }
        //        if (date < 10) {
        //            date = '0' + date;
        //        }
        //        return date + "-" + month + "-" + convertedDate.getFullYear();
        //    }
        //}

        //function getDsCuonSach() {
        //    $http
        //        .get('/AngularAPI/dsCuonSach?maTheDocGia=' + $scope.maTheDocGia)
        //        .then(function successCallback(response) {
        //            $scope.dsCuonSach = response.data;
        //        }, function errorCallback(error) {
        //            console.log(error);
        //        });
        //}

        //function nhapDocGia(maTheDocGia) {
        //    $scope.getDsCuonSach();
        //}

        ////Alert when user attempt to leave or reload this page
        //window.onbeforeunload = function () {
        //    return "Data will be lost if you leave the page, are you sure?";
        //};
    };
})();