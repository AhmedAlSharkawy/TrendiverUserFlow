<template>
  <div class="main-header">
    <img class="background-img" src="App/assets/homeWork.png" />
    <section class="overlay-layer"></section>
    <div class="header-content d-flex flex-column">
      <p class="main-title text-center p-md-2 mb-0">
        <b>
          Video On Demand & Paid
          <br />Live Streaming Marketplace
        </b>
      </p>
      <p class="context text-center">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
        Hac mauris, orci, egestas proin in bibendum.
      </p>
      <button class="btn header-signup">
        <b>Sign Up Now</b>
      </button>
    </div>
    <div class="cards-section">
      <slider-card class="container slider-card"></slider-card>
    </div>
  </div>
</template>

<style lang="less" scoped>
.main-header {
  position: relative;
  .background-img {
    width: 100%;
  }
  .overlay-layer {
    position: absolute;
    bottom: 0;
    top: 0;
    background: linear-gradient(65.12deg, #3512b1 0%, #7350f2 100%);
    opacity: 0.8;
    width: 100%;
  }
  .header-content {
    width: 100%;
    top: 35%;
    left: 50%;
    transform: translate(-50%, -50%);
    position: absolute;
    color: #f8f7fd;
    @media only screen and (max-width: 600px) {
      top: 50%;
      width: fit-content;
    }
    .main-title {
      font-size: 47px;
      @media only screen and (max-width: 600px) {
        font-size: 25px;
      }
    }
    .header-signup {
      color: #3512b1;
      background: #ffffff;
      box-shadow: 0px 0px 50px rgba(19, 19, 51, 0.1);
      border-radius: 8px;
      display: flex;
      margin: auto;
      padding: 12px 9px;
    }
    .context {
      @media only screen and (max-width: 600px) {
        display: none;
      }
    }
  }
  .cards-section {
    .slider-card {
      left: 50px;
      right: 50px;
      position: absolute;
      top: 350px;
      @media only screen and (max-width: 600px) {
        top: 173px;
        bottom: auto;
        left: 0;
        right: 0;
      }
      @media only screen and (device-width: 768px) {
        top: 304px;
      }
      @media screen and (min-width: 992px) {
        top: 622px;
      }
      @media (min-device-width: 1024px) and (max-device-width: 1024px) {
        top: 440px;
      }
    }
  }
}
</style>