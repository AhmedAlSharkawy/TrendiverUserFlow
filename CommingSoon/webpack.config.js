var path = require("path");
const VueLoaderPlugin = require("vue-loader/lib/plugin");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = {
  mode: "development",
  // Path to the 'primary' script of your project, that references all other built resources
  entry: {
    app: "./App/app.js",
    userFlow: "./App/userFlow.js",
  },
  output: {
    // Output directory and file name
    path: __dirname,
    filename: "[name].bundle.js",
  },
  module: {
    rules: [
      {
        test: /\.less$/,
        use: ["vue-style-loader", "css-loader", "less-loader"],
      },
      {
        test: /\.css$/,
        use: [
          MiniCssExtractPlugin.loader, // instead of style-loader
          "css-loader",
        ],
      },
      {
        test: /\.vue$/,
        use: [
          {
            loader: "vue-loader",
          },
          {
            loader: "vue-svg-inline-loader",
          },
        ],
      },
      {
        test: /\.m?js$/,
        exclude: /(node_modules|bower_components)/,
        use: {
          loader: "babel-loader",
          options: {
            presets: ["@babel/preset-env"],
          },
        },
      },
      {
        test: /\.(png|jpe?g|gif|svg)$/i, //this is not the right way to make svg works !!
        loader: "file-loader",
        options: {
          name: "[path][name].[ext]",
        },
      },
    ],
  },
  plugins: [new VueLoaderPlugin(), new MiniCssExtractPlugin()],
};
