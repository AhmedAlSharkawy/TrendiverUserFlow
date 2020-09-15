<template>
  <div>
    <uf-navbar></uf-navbar>
    <sub-navbar></sub-navbar>
    <home-header class="home-header"></home-header>
    <div class="empty-section"></div>
    <div class="container">
      <div class="video-section">
        <p class="video-main-title text-center">
          <b>Watch Your Favorite Content</b>
        </p>
        <section class="card-container">
          <p class="side-title">
            <b>Entertainment</b>
          </p>
          <section class="d-flex flex-row justify-content-around">
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
          </section>
        </section>
        <section class="card-container">
          <p class="side-title">
            <b>Science & Knowledge</b>
          </p>
          <section class="d-flex flex-row justify-content-around">
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
          </section>
        </section>
        <section class="card-container">
          <p class="side-title">
            <b>Health & Wellness</b>
          </p>
          <section class="d-flex flex-row justify-content-around">
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
          </section>
        </section>
        <section class="card-container">
          <p class="side-title">
            <b>Arts & Literature</b>
          </p>
          <section class="d-flex flex-row justify-content-around">
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
            <video-card></video-card>
          </section>
        </section>
      </div>
    </div>
    <pre-footer></pre-footer>
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
    height: 741px;
  }
}
.video-section {
  margin-top: 200px;
  position: relative;
  @media only screen and (max-width: 600px) {
    margin-top: 0;
  }
  @media only screen and (device-width: 768px) {
    margin-top: 200px;
  }
  @media (min-device-width: 1024px) and (max-device-width: 1024px) {
    margin-top: 120px;
  }
  .video-main-title {
    font-size: 40px;
    @media only screen and (max-width: 600px) {
      font-size: 25px;
      margin-top: 0;
    }
  }
  .card-container {
    margin-bottom: 40px;
  }
  .side-title {
    font-size: 20px;
  }
}
</style>