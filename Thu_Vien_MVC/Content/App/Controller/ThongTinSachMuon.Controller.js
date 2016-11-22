(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongTinSachMuonCtrl', ThongTinSachMuonCtrl);

    ThongTinSachMuonCtrl.$inject = ['$scope', '$http'];

    function ThongTinSachMuonCtrl($scope, $http) {
        $scope.maVachCuonSach;
        $scope.dsCuonSachInfo = [];

        $scope.togglePanelCuonSach = togglePanelCuonSach;
        $scope.removeCuonSach = removeCuonSach;
        $scope.detailPhieuMuon = detailPhieuMuon;

        function togglePanelCuonSach() {
            var flag = false;
            $scope.dsCuonSachInfo.forEach(function (item) {
                if (item.MaVach.toLowerCase() == $scope.maVachCuonSach.toLowerCase()) {
                    flag = true;
                    return;
                }
            });
            if (flag == false)
            {
                $http
                .get('/PhieuMuon/CuonSach/?maVach=' + $scope.maVachCuonSach)
                .then(function successCallback(response) {
                    console.log(response);
                    if (response.data != "") {
                        $scope.dsCuonSachInfo.push(response.data);
                        console.log(response.data);
                    }
                    else {
                        alert('Không tìm thấy mã vạch cuốn sách');
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
            }
            else
            {
                alert('Cuốn sách bạn chọn bị trùng');
            }
            
        }

        function removeCuonSach(maVach)
        {
            $scope.dsCuonSachInfo.forEach(function (item,index) {
                if(item.MaVach == maVach)
                {
                    $scope.dsCuonSachInfo.splice(index, 1);
                    return;
                }
            });
        }

        function detailPhieuMuon()
        {
            $http
                .post('/PhieuMuon/ChiTietPhieuMuon', $scope.dsCuonSachInfo)
                .then(function successCallback(response) {
                    console.log(response);
                    if (response.data != "") {
                        $scope.dsCuonSachInfo.push(response.data);
                        console.log(response.data);
                    }
                    else {
                        alert('Không tìm thấy mã vạch cuốn sách');
                    }
                }, function errorCallback(error) {
                    console.log(error);
                });
        }
    }

})();