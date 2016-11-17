const npm = require('global-npm');

var gulp = require('gulp'),
    config = require('./gulp.config')(__dirname),
    concat = require('gulp-concat'),
    sass = require('gulp-sass');

gulp.task('vendors', ['vendors-css'], function () {
    return gulp.src(config.vendors)
        .pipe(concat('vendors.js'))
        .pipe(gulp.dest(config.vendors.target));
});

gulp.task('vendors-css', function () {
    return gulp.src(config.vendors.css)
        .pipe(concat('vendors.css'))
        .pipe(gulp.dest(config.vendors.target));
});

gulp.task('build', ['vendors'], function () {
    return gulp.src(config.vendors.target)
        .pipe(concat());
});

gulp.task('bundle-ts', function (done) {
    npm.load({}, function (err) {
        if (err) {
            console.log('An error occured please try again.');
            return;
        }
        npm.commands.run(['build'], done);
    });
});

gulp.task('sass', function () {
    return gulp.src(config.sass.blob)
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest(config.sass.target));
});

//todo: build task
gulp.task('watch', function () {
    gulp.watch(config.sass.blob, ['sass']);
    gulp.watch(config.ts.target, ['bundle-ts']);
});