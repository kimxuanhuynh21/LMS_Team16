(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinNguoiMuonCtrl', ThongTinNguoiMuonCtrl);

    ThongTinNguoiMuonCtrl.$inject = ['$scope', '$http'];

    function ThongTinNguoiMuonCtrl($scope, $http) {
        $scope.docGiaInfoShow = true;
        $scope.dsSachMuonShow = false;
        $scope.phieuMuonShow = false;

        //Khai báo những scope mà mình sử dụng để hiển thị lên view
        $scope.maTheDocGia;
        $scope.docGiaInfo;
        $scope.lichSuMuon = [];
        $scope.panelDocGiaShow = false;
        var docGiaFlag = false;

        $scope.maVachCuonSach;
        $scope.dsCuonSachInfo = [];
        $scope.phieuMuon = {};

        //Functions
        $scope.togglePanelCuonSach = togglePanelCuonSach;
        $scope.removeCuonSach = removeCuonSach;
        $scope.detailPhieuMuon = detailPhieuMuon;
        $scope.togglePanelDocGia = togglePanelDocGia;
        $scope.displayDate = displayDate;
        $scope.submitDocGiaInfo = submitDocGiaInfo;

        function togglePanelDocGia() {
            //Gửi request có URL là '/PhieuMuon/DocGia/?maThe=' (sử dụng querystring) đến server. 
            //Server sẽ kiểm tra maThe nhận đc từ browser với db bên Controller và trả về response.
            $http
                .get('/PhieuMuon/DocGia/?maThe=' + $scope.maTheDocGia)
                .then(function successCallback(response) {
                    if (response.data != "") {
                        $scope.panelDocGiaShow = true;
                        //Lấy dữ liệu mà server trả về gán vào một thuộc tính scope để thuộc tính này mới hiển thị lên view.
                        $scope.docGiaInfo = response.data;
                        docGiaFlag = true;
                    }
                    else {
                        $scope.panelDocGiaShow = false;
                        alert('Không tìm thấy mã thẻ độc giả');
                        docGiaFlag = false;
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });

            //Gửi request có URL là '/PhieuMuon/LichSuMuon/?maThe=' (sử dụng querystring) đến sever. 
            //Server sẽ kiểm tra maThe nhận đc từ browser với db bên Controller và trả về response.
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

        //Khi click vào nút "Cho mượn sách" thì ng-show = "docGiaInfoShow" sẽ ẩn, ng-show = "dsSachMuonShow" sẽ hiện
        //Load cùng 1 trang
        function submitDocGiaInfo() {
            if (docGiaFlag == false) {
                alert('Bạn chưa chọn độc giả');
                return;
            }
            $scope.docGiaInfoShow = false;
            $scope.dsSachMuonShow = true;
        }

        //Thêm cuốn sách vào phiếu mượn
        //Khi click vào button có ng-click là togglePanelCuonSach()
        function togglePanelCuonSach(e) {
            var flag = false;
            $scope.dsCuonSachInfo.forEach(function (item) {              //Chạy vòng lập đối với javascript    
                if (item.MaVach.toLowerCase() == $scope.maVachCuonSach.toLowerCase()) {
                    flag = true;
                    return;
                }
            });
            if (flag == false) {
                $http
                .get('/PhieuMuon/CuonSach/?maVach=' + $scope.maVachCuonSach)
                .then(function successCallback(response) {
                    if (response.data != "") {
                        $scope.dsCuonSachInfo.push(response.data);           //push để thêm dữ liệu vào mảng
                        
                    }
                    else {
                        alert('Không tìm thấy mã vạch cuốn sách');
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
            }
            else {
                alert('Cuốn sách bạn chọn bị trùng');
            }
            e.preventDefault();
        }

        //Xóa sách được chọn
        function removeCuonSach(maVach) {
            $scope.dsCuonSachInfo.forEach(function (item, index) {
                if (item.MaVach == maVach) {
                    $scope.dsCuonSachInfo.splice(index, 1);     //hàm splice dùng để xóa
                    return;
                }
            });
        }

        function detailPhieuMuon() {
            var requestData = {
                docGia: $scope.docGiaInfo,
                dsCuonSach: $scope.dsCuonSachInfo
            };
            $http
                .post('/PhieuMuon/ChiTietPhieuMuon', requestData)
                .then(function successCallback(response) {
                    console.log(response);
                    if (response.data != "") {
                        $scope.phieuMuon = response.data;
                        $scope.dsSachMuonShow = false;
                        $scope.phieuMuonShow = true;
                        console.log($scope.phieuMuon);
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
        }

        //Alert when user attempt to leave or reload this page
        window.onbeforeunload = function () {
            return "Data will be lost if you leave the page, are you sure?";
        };
    }

})();