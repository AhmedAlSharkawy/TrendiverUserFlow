<template>
  <div>
    <uf-navbar></uf-navbar>
    <sub-navbar></sub-navbar>
    <slider-card></slider-card>
    <br />
    <div class="container">
      <p class="card-slider-title text-center">
        <b>Watch Your Favorite Content</b>
      </p>
      <div class="card-slider-section d-flex flex-row justify-content-around">
        <video-card></video-card>
        <video-card></video-card>
        <video-card></video-card>
        <video-card></video-card>
      </div>

      <br />
    </div>
    <pre-footer></pre-footer>
    <uf-footer></uf-footer>
  </div>
</template>

<style lang="less" scoped>
.card-slider-title {
  font-size: 40px;
  color: #131333;
  @media only screen and (max-width: 600px) {
    font-size: 20px;
  }
}
.card-slider-section {
  overflow-x: auto;
}
</style>