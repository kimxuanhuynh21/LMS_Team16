(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinNguoiTraCtrl', ThongTinNguoiTraCtrl);

    ThongTinNguoiTraCtrl.$inject = ['$scope', '$http'];

    function ThongTinNguoiTraCtrl($scope,$http)
    {
        $scope.maPhieuMuon;
        $scope.phieuMuonInfo;
        $scope.panelPhieuTraShow = false;
        var phieuMuonFlag = false;
        $scope.dsSachTraShow = false;
        $scope.phieuMuonShow = true;
        $scope.dsSachTra = [];
        $scope.maVachSachTra;
        $scope.phieuTraShow = false;
        
        //function
        $scope.togglePanelPhieuMuon = togglePanelPhieuMuon;
        $scope.displayDate = displayDate;
        $scope.submitPhieuMuonInfo = submitPhieuMuonInfo;
        $scope.togglePanelSachTra = togglePanelSachTra;
        $scope.removeCuonSach = removeCuonSach;
        $scope.detailPhieuTra = detailPhieuTra;

        function togglePanelPhieuMuon()
        {
            $http
                .get('/PhieuTra/PhieuMuon/?maPhieuMuon=' + $scope.maPhieuMuon)
                .then(function successCallback(response) {
                    if(response.data != "")
                    {
                        $scope.panelPhieuTraShow = true;
                        $scope.phieuMuonInfo = response.data;
                        phieuMuonFlag = true;
                    }
                    else
                    {
                        alert('Không tìm thấy phiếu mượn');
                        phieuMuonFlag = false;
                    }
                },
                function errorCallback(error) {
                    console.log(error);
                });
        }

        function submitPhieuMuonInfo()
        {
            if(phieuMuonFlag == false)
            {
                alert('Bạn chưa chọn phiếu mượn');
            }
            else
            {
                $scope.phieuMuonShow = false;
                $scope.dsSachTraShow = true;
            }
        }

        function togglePanelSachTra()
        {
            var flag = false;
            $scope.dsSachTra.forEach(function (item) {
                if (item.CuonSach.MaVach.toLowerCase() == $scope.maVachSachTra.toLowerCase())
                {
                    flag = true;
                    return;
                }
            });
            if (flag == false)
            {
                $http
                    .get('/PhieuTra/CuonSach/?maVach='+ $scope.maVachSachTra + '&maPhieuMuon=' + $scope.maPhieuMuon)
                    .then(function successCallBack(response) {
                        if(response.data != "")
                        {
                            $scope.dsSachTra.push(response.data);
                        }
                        else
                        {
                            alert('Không tìm thấy mã vạch cuốn sách');
                        }
                    }, function errorCallBack(error) {
                        console.log(error);
                    });
            }
            else
            {
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

        function detailPhieuTra()
        {
            var requestData = {
                phieuMuon: $scope.phieuMuonInfo,
                dsChiTietMuon: $scope.dsSachTra
            };
            $http
                .post('/PhieuTra/ChiTietPhieuTra', requestData)
                .then(function successCallback(response) {
                    if (response.data != "")
                    {
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

        //Alert when user attempt to leave or reload this page
        window.onbeforeunload = function () {
            return "Data will be lost if you leave the page, are you sure?";
        };
    }
})();