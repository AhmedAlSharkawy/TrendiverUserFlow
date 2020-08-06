<template>
  <div>
    <uf-navbar></uf-navbar>
    <sub-navbar></sub-navbar>
    <home-header class="home-header"></home-header>
    <div class="container">
      <slider-card class="slider-card"></slider-card>
      <br />
      <video-card></video-card>
    </div>
    <pre-footer></pre-footer>
    <uf-footer></uf-footer>
  </div>
</template>

<style lang="less" scoped>
.home-header {
  position: relative;
}
.container {
  .slider-card {
    position: absolute;
  }
}
</style>