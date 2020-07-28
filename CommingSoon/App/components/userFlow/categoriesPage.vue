<template>
  <div>
    <uf-navbar></uf-navbar>
    <sub-navbar></sub-navbar>
    <div class="container">
      <p class="provider-title text-center">
        <b>Our Instructors</b>
      </p>
      <div class="provider-section d-flex flex-row flex-wrap">
        <instructor-card></instructor-card>
        <instructor-card></instructor-card>
        <instructor-card></instructor-card>
      </div>
    </div>
    <pre-footer></pre-footer>
    <uf-footer></uf-footer>
  </div>
</template>

<style lang="less" scoped>
  .provider-title {
    font-size: 40px;
    color: #131333;
      @media only screen and (max-width: 600px) {
        font-size: 20px;
      }
  }
</style>