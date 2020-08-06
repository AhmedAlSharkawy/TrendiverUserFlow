<template>
  <div class="main-header">
    <img class="background-img" src="App/assets/homeWork.png" />
    <section class="transparent-layer">
      <h1 class="text-center p-4">
        Video On Demand & Paid
        <br />Live Streaming Marketplace
      </h1>
      <p class="text-center">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
        Hac mauris, orci, egestas proin in bibendum.
      </p>
      <button class="btn header-signup"><b>Sign Up Now</b></button>
    </section>
  </div>
</template>

<style lang="less" scoped>
.main-header {
  .background-img {
    width: 100%;
    position: relative;
  }
  .transparent-layer {
    color: #f8f7fd;
    position: absolute;
    bottom: 0;
    background: linear-gradient(65.12deg, #3512b1 0%, #7350f2 100%);
    opacity: 0.8;
    width: 100%;
    .header-signup {
      color: #3512b1;
      background: #ffffff;
      box-shadow: 0px 0px 50px rgba(19, 19, 51, 0.1);
      border-radius: 8px;
      display: flex;
      margin: auto;
      padding: 12px 9px;
    }
  }
}
</style>