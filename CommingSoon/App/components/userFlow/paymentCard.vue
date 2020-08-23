<template>
  <div class="payment-card col-md-3">
    <p class="main-price pt-4">
      <b>EGP 1090</b>
    </p>
    <button class="buynow-btn" type="submit">
      <b>Buy Now</b>
    </button>
    <div class="card-separator mt-4">
      <div class="separator text-center">
        <span>OR</span>
      </div>
    </div>
    <p class="video-price">
      <b>EGP 100</b>
    </p>
    <button class="payvideo-btn">
      <b>Pay Per Video</b>
    </button>
    <div class="card-content mt-5">
      <p class="mb-4">This Content features:</p>
      <div class="d-flex flex-row">
        <img svg-inline src="../../assets/play.svg" />
        <section class=" recorded d-flex flex-column pl-2">
          <p class="recorded-text mb-0">Recorded</p>
          <p>11.5 hours on-demand</p>
        </section>
      </div>
      <section class="d-flex flex-row">
        <img svg-inline src="../../assets/document.svg" />
        <p class="pl-2">25 Shareable Documents</p>
      </section>
      <section class="d-flex flex-row">
        <img svg-inline src="../../assets/certification.svg" />
        <p class="pl-2">Certification</p>
      </section>
      <section class="d-flex flex-row">
        <img svg-inline src="../../assets/Time.svg" />
        <p class="pl-2">Unlimited access</p>
      </section>
    </div>
  </div>
</template>


<style lang="less" scoped>
.payment-card {
  background: #f3f5f7;
  border-radius: 8px;
  .main-price {
    color: #3512b1;
  }
  .buynow-btn {
    background: #feca55;
    box-shadow: 0px 2px 4px rgba(40, 41, 61, 0.04),
      0px 8px 16px rgba(96, 97, 112, 0.16);
    border-radius: 8px;
    border: none;
    padding: 10px 30px;
    color: #ffffff;
    width: inherit;
  }
  .card-separator {
    border-bottom: 1px solid #d3d9de;
    margin-bottom: 20px;
    .separator {
      position: relative;
      margin-top: 10px;
      margin-bottom: -12px;
      span {
        color: #9299a0;
        background-color: #f3f5f7;
        font-size: 16px;
        padding: 0 10px;
      }
    }
  }
  .video-price {
    color: #495057;
  }
  .payvideo-btn {
    background: #ffffff;
    box-shadow: 0px 2px 4px rgba(40, 41, 61, 0.04),
      0px 8px 16px rgba(96, 97, 112, 0.16);
    border-radius: 8px;
    border: none;
    width: inherit;
    padding: 14px 30px;
    color: #3512b1;
    font-size: 14px;
  }
  .card-content {
    p {
      color: #495057;
    }
    .recorded {
      margin-top: -11px;
      .recorded-text {
        font-size: 14px;
        color: #3512B1;
      }
    }
  }
}
</style>