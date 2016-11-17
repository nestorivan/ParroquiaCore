import * as angular from 'angular';
import { homeCtrl } from './home.controller';

export let module = angular.module('mandarinhr', [
    'ngAnimate',
    'ngAria',
    'ngMaterial',
    'ui.router'
]);

module.controller('homeCtrl', homeCtrl);