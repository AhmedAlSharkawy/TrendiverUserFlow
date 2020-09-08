<template>
  <div>
    <uf-navbar></uf-navbar>
    <!-- <content-header></content-header> -->
    <sub-navbar></sub-navbar>
    <product-header></product-header>
    <!-- <home-header class="home-header"></home-header> -->
    <div class="empty-section"></div>
    <div class="container">
      <div class="video-section">
        <p class="video-main-title text-center">
          <b>Watch Your Favorite Content</b>
        </p>
        <section>
          <p class="side-title">
            <b>Entertainment</b>
          </p>
          <video-card></video-card>
        </section>
      </div>
    </div>
    <!-- <pre-footer></pre-footer> -->
    <uf-footer></uf-footer>
  </div>
</template>

<style lang="less" scoped>
.empty-section {
  position: relative;
  height: 800px;
  float: left;
  @media only screen and (max-width: 600px) {
    float: none;
  }
}
.video-section {
  margin-top: 100px;
  position: relative;
  @media only screen and (max-width: 600px) {
    margin-top: 0;
  }
  .video-main-title {
    font-size: 40px;
    margin-top: 150px;
    @media only screen and (max-width: 600px) {
      font-size: 25px;
      margin-top: 0;
    }
  }
  .side-title {
    font-size: 20px;
  }
}
</style>