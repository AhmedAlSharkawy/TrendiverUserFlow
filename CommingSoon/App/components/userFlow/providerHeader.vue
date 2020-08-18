<template>
  <div class="provider-header">
    <img class="background-img" src="App/assets/providerHeader.png" />
    <div class="header-content d-flex flex-column">
      <p class="main-title text-center p-md-2 mb-sm-0">
        <b>Content provider Name</b>
      </p>
      <p class="context text-center">
        A Complete MBA Training: Business Strategy, Management, Marketing,
        <br class="d-sm-none d-md-block" />Accounting, Decision Making & Negotiation
      </p>
    </div>
    <img class="provider-logo" src="App/assets/providerLogo.png" />
  </div>
</template>


<style lang="less" scoped>
.provider-header {
    position: relative;
  .background-img {
    width: 100%;
  }
  .header-content {
    width: 100%;
    top: 50%;
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
  }
  .provider-logo {
    position: absolute;
    top: 99%;
    left: 50%;
    transform: translate(-50%, -50%);
    box-shadow: 0px 0px 15px rgba(19, 19, 51, 0.1);
    width: 15%;
    background-color: white;
    border-radius: 80px;
  }
}
</style>