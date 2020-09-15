<template>
  <div class="pre-footer-section">
    <img class="background-img" svg-inline src="../../assets/Background.svg" />
    <div class="d-flex flex-row container">
      <div class="pre-footer">
        <div class="pre-footer-content">
          <p class="pre-footer-title mb-md-4 mb-0">
            <b>Record, Upload, Monetize</b>
          </p>
          <p class="content mb-0">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eu facilisis lorem, a laoreet lorem.
            <br />Donec ac turpis semper,
          </p>
          <button class="creator-btn mt-md-5 mt-0" type="submit">
            <b>Become a Creator</b>
          </button>
        </div>
      </div>
      <img class="instructor-img" src="App/assets/instructorf.png" />
    </div>
  </div>
</template>


<style lang="less" scoped>
.pre-footer-section {
  position: relative;
  margin-top: 160px;
  @media only screen and (max-width: 600px) {
    margin-top: 0;
  }
  .background-img {
    width: 100%;
    height: auto;
  }
  .pre-footer {
    .pre-footer-content {
      top: 60px;
      bottom: 0;
      color: #f8f7fd;
      position: absolute;
      line-height: 2.5;
      @media only screen and (max-width: 600px) {
        line-height: 1.5;
        bottom: 0;
        top: 3px;
      }
      @media only screen and (device-width: 768px) {
        top: 23px;
        line-height: 1.7;
      }
      @media (min-device-width: 1024px) and (max-device-width: 1366px) {
        top: 51px;
      }
      .pre-footer-title {
        font-size: 40px;
        @media only screen and (max-width: 600px) {
          font-size: 20px;
          text-align: center;
        }
      }
      .content {
        @media only screen and (max-width: 600px) {
          text-align: center;
          br {
            display: none;
          }
        }
      }
    }
    .creator-btn {
      background: #feca55;
      border-radius: 8px;
      border: none;
      padding: 2px 30px;
      color: #ffffff;
      @media only screen and (max-width: 600px) {
        margin-left: auto;
        margin-right: auto;
        display: block;
      }
    }
  }
  .instructor-img {
    position: absolute;
    left: 68%;
    top: -32%;
    width: 23%;
    box-shadow: 14px 13px 2px #feca55;
    border-radius: 8px;
    @media only screen and (max-width: 600px) {
      display: none;
    }
    @media only screen and (device-width: 768px) {
      left: 70%;
    }
  }
}
</style>