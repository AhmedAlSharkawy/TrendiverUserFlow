<template>
  <div class="product-header">
    <img class="background-img" src="App/assets/product.png" />
    <section class="overlay-layer"></section>
    <div class="header-content d-flex flex-column p-md-5 p-2 mb-sm-0">
      <div class="d-flex flex-row">
        <img svg-inline class="mr-2" src="../../assets/userPhoto.svg" />
        <p class="mb-0">
          <b>Moo Islam</b>
        </p>
      </div>
      <p class="main-title">
        <b>Business Analytics for Begginers</b>
      </p>
      <p class="context">
        A Complete MBA Training: Business Strategy, Management, Marketing,
        <br />Accounting, Decision Making & Negotiation
      </p>
      <div class="d-flex flex-row">
        <section class="d-flex flex-row">
          <img svg-inline src="../../assets/talk.svg" />
          <p class="pl-2 mb-0">Arabic</p>
        </section>
        <section class="d-flex flex-row pl-5">
          <img svg-inline src="../../assets/views.svg" />
          <p class="pl-2 mb-0">25653 Views</p>
        </section>
      </div>
    </div>
  </div>
</template>


<style lang="less" scoped>
.product-header {
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
    position: absolute;
    color: #f8f7fd;
    width: 100%;
    top: 125px;
    @media only screen and (max-width: 600px) {
      top: -3px;
    }
    @media only screen and (device-width: 768px) {
      top: -12px;
    }
    @media (min-device-width: 1024px) and (max-device-width: 1366px) {
      top: 50px;
    }
    .main-title {
      font-size: 47px;
      @media only screen and (max-width: 600px) {
        font-size: 20px;
        margin-bottom: 0;
      }
      @media only screen and (device-width: 768px) {
        font-size: 42px;
      }
    }
    .context {
      font-size: 18px;
      @media only screen and (max-width: 600px) {
        font-size: 14px;
        margin-bottom: 0;
        br {
          display: none;
        }
      }
    }
  }
}
</style>