<template>
  <div class="content-header d-flex flex-row justify-content-between">
    <section class="d-flex flex-row">
      <img class="logo-img ml-4" src="App/assets/logo.png" />
      <p class="header-title ml-2 mt-2 mb-0" href="#">
        <b>Trendiver</b>
      </p>
    </section>
    <section class="my-account">
      <a href="#" class="mr-4">My Account</a>
    </section>
  </div>
</template>


<style lang="less" scoped>
.content-header {
  background: #f3f5f7;
  height: 60px;
  align-items: center;
  .logo-img {
    width: 40px;
    height: 40px;
  }
  .header-title {
    font-size: 14px;
  }
  .my-account {
      a {color: #131333;}
  }
}
</style>