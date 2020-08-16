<template>
  <div class="pre-footer-section mt-5">
    <img class="background-img" svg-inline src="../../assets/Background.svg" />
    <div class="d-flex flex-row container">
      <div class="pre-footer">
        <div class="pre-footer-content">
          <p class="pre-footer-title mb-md-4 mb-0">
            <b>Record, Upload, Monetize</b>
          </p>
          <p class="mb-0">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eu facilisis lorem, a laoreet lorem.
            <br />Donec ac turpis semper, viverra lorem vel, sagittis dui.
          </p>
          <button class="creator-btn mt-md-4 mt-0" type="submit">
            <b>Become a Creator</b>
          </button>
        </div>
      </div>
      <img class="instructor-img" src="App/assets/instructor.png" />
    </div>
  </div>
</template>


<style lang="less" scoped>
.pre-footer-section {
  position: relative;
  .background-img {
    width: 100%;
    height: auto;
  }
  .pre-footer {
    .pre-footer-content {
      top: 30px;
      bottom: 0;
      color: #f8f7fd;
      position: absolute;
      line-height: 2.5;
      @media only screen and (max-width: 600px) {
        line-height: 1.5;
        bottom: 0;
        top: 10px;
      }
      .pre-footer-title {
        font-size: 40px;
        @media only screen and (max-width: 600px) {
          font-size: 20px;
        }
      }
    }
    .creator-btn {
      background: #feca55;
      border-radius: 8px;
      border: none;
      padding: 2px 30px;
      color: #ffffff;
    }
  }
}
</style>