(function() {
    
    var app = angular.module('PortfolioApp', []);


    app.controller('ProjectController', function($scope, $http) {

        var apiProject = {
            Name: 'OneCraftyMiss',
            Description: 'blahblahblah',
            Publishdate: '05/02/2014',
            Rype: 'WebDev',
            Active: true
        }

        $scope.Project = apiProject;

        $scope.Projects = [];
        var responsePromise = $http.get("api/Projects");

        responsePromise.success(function (data, status, headers, config) {

            $scope.Projects = data;

        });
        responsePromise.error(function(data, status, headers, config) {
            alert("api call fail");
        });


    });



})();