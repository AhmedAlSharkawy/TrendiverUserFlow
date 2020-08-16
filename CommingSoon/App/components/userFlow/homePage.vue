<template>
  <div>
    <uf-navbar></uf-navbar>
    <sub-navbar></sub-navbar>
    <home-header class="home-header"></home-header>
    <div class="container">    
      <br />
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
    <pre-footer></pre-footer>
    <uf-footer></uf-footer>
  </div>
</template>

<style lang="less" scoped>
.video-section {
  margin-top: 100px;
    @media only screen and (max-width: 600px) {
      margin-top: 10px;
    }
  .video-main-title {
   font-size: 40px;
     @media only screen and (max-width: 600px) {
       font-size: 20px;
     }
  }
  .side-title {
    font-size: 20px;
  }
}
</style>