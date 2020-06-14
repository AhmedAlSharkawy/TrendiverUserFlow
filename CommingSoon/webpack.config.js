var path = require('path');
const VueLoaderPlugin = require('vue-loader/lib/plugin')

module.exports = {
    mode: 'development',
    // Path to the 'primary' script of your project, that references all other built resources
    entry: './App/app.js',
    output: {
        // Output directory and file name
        path: path.resolve(__dirname, 'build'),
        filename: 'build.js'
    },
    module: {
        rules: [
          { 
            test: /\.less$/, 
            use: [
              'vue-style-loader',
              'css-loader',
              'less-loader'
            ]
          },
          {
            test: /\.vue$/,
            loader: 'vue-loader'
          },
          {
            test: /\.m?js$/,
            exclude: /(node_modules|bower_components)/,
            use: {
              loader: 'babel-loader',
              options: {
                presets: ['@babel/preset-env']
              }
            }
          },
          {
            test: /\.(png|jpe?g|gif|svg)$/i,
            loader: 'file-loader',
            options: {
              name: '[path][name].[ext]',
            },
          },
        ]
      },
      plugins: [
        new VueLoaderPlugin()
      ]
};