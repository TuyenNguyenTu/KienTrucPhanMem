(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider', '$locationProvider', '$qProvider',
        function ($stateProvider, $urlRouterProvider, $locationProvider, $qProvider) {
            $locationProvider.hashPrefix('');
            $urlRouterProvider.otherwise('/');
            $qProvider.errorOnUnhandledRejections(false);

            if (abp.auth.hasPermission('Pages.Users')) {
                $stateProvider
                    .state('users', {
                        url: '/users',
                        templateUrl: '/App/Main/views/users/index.cshtml',
                        menu: 'Users' //Matches to name of 'Users' menu in KienTrucPhanMemNavigationProvider
                    })
                    .state('roles', {
                        url: '/roles',
                        templateUrl: '/App/Main/views/roles/index.cshtml',
                        menu: 'Roles' //Matches to name of 'Tenants' menu in KienTrucPhanMemNavigationProvider
                    })
                    .state('tenants', {
                        url: '/tenants',
                        templateUrl: '/App/Main/views/tenants/index.cshtml',
                        menu: 'Tenants' //Matches to name of 'Tenants' menu in KienTrucPhanMemNavigationProvider
                    });

                $urlRouterProvider.otherwise('/users');
            }
            if (abp.auth.hasPermission('Pages.Tiep_Nhan')){
                $stateProvider
                    .state('ql-benh-nhan', {
                        url: '/ql-benh-nhan',
                        templateUrl: '/App/Main/views/TiepNhan/index.cshtml',
                        menu: 'Users'
                    })
                    .state('ql-phieu-dang-ky-kham', {
                        url: '/ql-phieu-dang-ky-kham',
                        templateUrl: '/App/Main/views/TiepNhan/phieudangky.cshtml',
                        menu: 'Users'
                    })
                    .state('ql-phieu-su-dung-dich-vu', {
                        url: '/ql-phieu-su-dung-dich-vu',
                        templateUrl: '/App/Main/views/TiepNhan/dichvu.cshtml',
                        menu: 'Users'
                    })
                $urlRouterProvider.otherwise('/users')
            }
            if (abp.auth.hasPermission('Pages.Quan_Tri')) {
                $stateProvider
                    //.state('users', {
                    //    url: '/users',
                    //    templateUrl: '/App/Main/views/users/index.cshtml',
                    //    menu: 'Users'
                    //})
                    //.state('roles', {
                    //    url: '/roles',
                    //    templateUrl: '/App/Main/views/roles/index.cshtml',
                    //    menu: 'Roles' //Matches to name of 'Tenants' menu in KienTrucPhanMemNavigationProvider
                    //});
                $urlRouterProvider.otherwise('/users')
            }

            //if (abp.auth.hasPermission('Pages.Roles')) {
            //    $stateProvider
            //        .state('roles', {
            //            url: '/roles',
            //            templateUrl: '/App/Main/views/roles/index.cshtml',
            //            menu: 'Roles' //Matches to name of 'Tenants' menu in KienTrucPhanMemNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/roles');
            //}

            //if (abp.auth.hasPermission('Pages.Tenants')) {
            //    $stateProvider
            //        .state('tenants', {
            //            url: '/tenants',
            //            templateUrl: '/App/Main/views/tenants/index.cshtml',
            //            menu: 'Tenants' //Matches to name of 'Tenants' menu in KienTrucPhanMemNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/tenants');
            //}

            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in KienTrucPhanMemNavigationProvider
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in KienTrucPhanMemNavigationProvider
                });
        }
    ]);

})();