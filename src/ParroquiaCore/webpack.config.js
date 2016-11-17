var path = require('path'),
    root = __dirname;

module.exports = {
    entry: {
        app: root + '/ts/app.ts'
    },
    devtool: 'source-map',
    output: {
        path: './wwwroot/build/app/',
        filename: '[name].js'
    },
    resolve: {
        extensions: ['', '.webpack.js', '.web.js', '.ts', '.js']
    },
    module: {
        loaders: [{
            test: /\.ts?$/,
            loader: 'ts-loader'
        }]
    }
}