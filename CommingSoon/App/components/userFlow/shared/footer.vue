<template>
  <div class="footer-section">
    <div class="footer p-5 d-flex flex-row justify-content-around">
      <div class="col-3">
        <section class="d-flex flex-row">
          <img src="../../../../build/63e5830e485df268d38495c37166b21e.png" />
          <p>
            <b>Trendiver</b>
          </p>
        </section>
        <p class="p-2">
          Video on demand & paid
          live streaming marketplace
        </p>
      </div>
      <section class="inner-section col-3 d-flex flex-column">
        <p>
          <b>Site Map</b>
        </p>
        <a>Entertainment</a>
        <a>Science & Knowledge</a>
        <a>Sports</a>
        <a>Arts & Literature</a>
      </section>
      <section class="col-3">
        <p>
          <b>Newsletter</b>
        </p>
        <p>
          Sign up in our Newsletter
          to get weekly updates
        </p>
        <form>
          <input class="footer-input p-2 mb-2" placeholder="Enter your Email" />
          <button class="btn footer-signup">Sign Up</button>
        </form>
      </section>
    </div>
    <div class="copy-right text-center">
      <p class="p-3 m-0">Copyright &copy; 2016-2020 Trendiver.Com</p>
    </div>
  </div>
</template>

<style lang="less" scoped>
.footer-section {
    margin-top: 20px;
  .footer {
    background: #e7ebee;
    .inner-section {
      a {
        margin-bottom: 17px;
      }
    }
    .footer-input {
      background: #d3d9de;
      border-radius: 8px;
      border: none;
      height: 39px;
      width: 290px;
      outline: none;
    }
    .footer-signup {
      background: #feca55;
      border-radius: 8px;
      outline: none;
      color: white;
    }
  }
  .copy-right {
    background: #d3d9de;
  }
}
</style>