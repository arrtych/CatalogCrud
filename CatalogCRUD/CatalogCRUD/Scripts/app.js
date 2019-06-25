angular.module('myApp', ['angucomplete-alt'])
    .controller('myController', ['$scope','$http', function ($scope,$http) {
        var init = function () {
            GetCategories();
            GetBooks();
            GetAllBooks()
            getCategoryNames()
        }
            init();

        function getCategoryNames() {
            $http({
                method: 'Get',
                url: '/categories'
            }).success(function (data, status, headers, config) {
                $scope.CategoryNames = data;
            }).error(function (data, status, headers, config) {
                $scope.message = 'Unexpected Error';
            });
        }

        function GetBooks() {
            $http({
                method: 'Get',
                url: '/Book/GetBooks'
            }).success(function (data, status, headers, config) {

                $scope.search = {};
                $scope.searchBy = '$';
                $scope.Books = data;
                console.log($scope);
            }).error(function (data, status, headers, config) {
                $scope.message = 'Unexpected Error';
            });
        }

        function GetAllBooks() {
            $http({
                method: 'Get',
                url: '/Book/GetAllBooks'
            }).success(function (data, status, headers, config) {

                $scope.search = {};
                $scope.searchBy = '$';
                $scope.GetAllBooks = data;
                console.log($scope);
            }).error(function (data, status, headers, config) {
                $scope.message = 'Unexpected Error';
            });
        }

        function GetCategories() {
            $http({
                method: 'Get',
                url: '/Book/GetCategories'
            }).success(function (data, status, headers, config) {
                $scope.SelectedCategories = null;
                $scope.Categories = data;

            }).error(function (data, status, headers, config) {
                $scope.message = 'Unexpected Error';
            });
        }

       /* $scope.complete = function (string) {            
            console.log("cats: ",$scope.CategoryNames);
            $scope.countryList = [
                "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Virgin Islands (U.S.)", "Wallis and Futuna Islands", "Western Sahara", "Yemen", "Yugoslavia", "Zambia", "Zimbabwe"
            ];
            $scope.hidethis = false;
            var output = [];
            angular.forEach($scope.CategoryNames, function (category) {
                if (category.toLowerCase().indexOf(string.toLowerCase()) >= 0) {
                    output.push(category);
                }
            });
            $scope.filterCategory = output;
            
        }
        $scope.fillTextbox = function (string) {
            $scope.category = string;
            $scope.hidethis = true;
        } */
       

      
        /*
        function GetCurrentCategory(categoryId) {
            $http({
                method: 'Get',
                url: '/Book/Edit/' + categoryId
            }).success(function (data, status, headers, config) {
                $scope.categoryId = data;
                console.log($scope.categoryId);
            }).error(function (data, status, headers, config) {
                $scope.message = 'Unexpected Error';
            });
        }*/


    }]);
