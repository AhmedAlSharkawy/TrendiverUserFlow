<template>
  <div class="footer-section">
    <div class="footer container pt-md-5 p-4 justify-content-around">
      <section class="col-md-4 p-0">
        <section class="d-flex flex-row">
          <img src="../../../../build/63e5830e485df268d38495c37166b21e.png" />
          <p>
            <b>Trendiver</b>
          </p>
        </section>
        <p class="p-2">
          Video on demand & paid
          <br />live streaming marketplace
        </p>
      </section>
      <section class="inner-section col-md-4 p-0">
        <p>
          <b>Site Map</b>
        </p>
        <a>Entertainment</a>
        <a>Science & Knowledge</a>
        <a>Sports</a>
        <a>Arts & Literature</a>
      </section>
      <section class="col-md-4 p-0">
        <p>
          <b>Newsletter</b>
        </p>
        <p>
          Sign up in our Newsletter to
          <br />get weekly updates
        </p>
        <form>
          <input class="footer-input p-2 mr-2 mb-2" placeholder="Enter your Email" />
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
  background: #e7ebee;
  .footer {
    display: flex;
    flex-direction: row;
    @media only screen and (max-width: 600px) {
      display: flex;
      flex-direction: column;
    }
    .inner-section {
      display: flex;
      flex-direction: column;
      a {
        margin-bottom: 17px;
      }
    }
    .footer-input {
      background: #d3d9de;
      border-radius: 8px;
      border: none;
      height: 39px;
      width: 100%;
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