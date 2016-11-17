module.exports = function (root) {
    
    var config = {};

    config.vendors = [
        './node_modules/angular/angular.min.js',
        './node_modules/angular-ui-router/release/angular-ui-router.min.js',
        './node_modules/angular-animate/angular-animate.min.js',
        './node_modules/angular-aria/angular-aria.min.js',
        './node_modules/angular-material/angular-material.js'
    ];

    config.vendors.css = [
        './node_modules/angular-material/angular-material.css'
    ];

    config.vendors.target = root + '/wwwroot/build/vendors';

    config.ts = {
        target: root + '/scripts/**/*.ts'
    };

    config.sass = {
        blob: root + '/src/styles/**/*.{scss,css,sass}',
        target: root + '/wwwroot/build/css'
    };

    config.buildpath = root + 'wwwroot/build';

    return config;
};