

(function () {
    'use strict';

    angular
        .module('LMSApp')
        .controller('ThongKeSachMuonCtrl', ThongKeSachMuonCtrl);

    ThongKeSachMuonCtrl.$inject = ['$scope', '$http', '$filter'];

    function ThongKeSachMuonCtrl($scope, $http, $filter) {

        $scope.data_statistic = [];
        $scope.data_reader = [];
        $scope.displayDate = displayDate;

        $scope.submit = function () {
            var fd = new FormData();
            var docgia_id = document.getElementById("cbb_docgia").value;
            var datefrom = document.getElementById("cbb_datefrom").value;
            var dateto = document.getElementById("cbb_dateto").value;
            fd.append("DocGiaID", docgia_id);
            fd.append("DateFrom", datefrom);
            fd.append("DateTo", dateto);
            $http.post('/ThongKe/GetDataStatistic', fd, {
                transformRequest: angular.identity,
                headers: { 'Content-Type': undefined }
            })
              .success(function (result) {
                  if (result == "error") {
                      open_alert("error");
                  } else {
                      $scope.data_statistic = [];
                      angular.forEach(result.Data_Statistic, function (value, key) {

                          var format_date = value.NgayMuon;
                          format_date = format_date.substring(1, format_date.length - 1);

                          var begin = format_date.indexOf("(");
                          var end = format_date.lastIndexOf(")")
                          var obj = {
                              NgayMuon: new Date((format_date.substring(begin + 1, end)) * 1),
                              PhieuMuonID: value.PhieuMuonID,
                              MaVachCuonSach: value.MaVachCuonSach,
                              DauSachID: value.DauSachID,
                              TenDauSach: value.TenDauSach,
                          };

                          console.log(format_date.substring(begin + 1, end));

                          $scope.data_statistic.push(obj);

                      });
                      $scope.data_reader = result.Data_reader;
                  }
              });
        };

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