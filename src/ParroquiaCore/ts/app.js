"use strict";
var angular = require('angular');
var home_controller_1 = require('./home.controller');
exports.module = angular.module('mandarinhr', [
    'ngAnimate',
    'ngAria',
    'ngMaterial',
    'ui.router'
]);
exports.module.controller('homeCtrl', home_controller_1.homeCtrl);
