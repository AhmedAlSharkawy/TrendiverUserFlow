<template>
  <div>
    <div class="card">
      <div>
      <img svg-inline class="card-img-top" src="../../assets/work.svg" />
      </div>
      <div class="card-body">
        <p class="sub-title mb-1">Recorded</p>
        <p class="card-title"> <b>Business Analytics</b></p>
        <div class="card-content d-flex flex-row">
          <img svg-inline class="mr-2"  src="../../assets/userPhoto.svg" />
          <p class="card-content-text"><b>Moo Islam</b></p>
        </div>
        <p class="card-price mt-3">EGP 1090</p>
      </div>
    </div>
  </div>
</template>

<style lang="less" scoped>
.card {
  box-shadow: 0px 0px 8px rgba(19, 19, 51, 0.15);
  border-radius: 8px;
  width: 17rem;
  .card-img-top {
    width: 275px;
    height: auto;
  }
  .card-body {
    .sub-title {
      font-size: 14px;
      color: #131333;
    }
    .card-title {
      font-size: 18px;
      color: #3512B1;
    }
    .card-price {
      font-size: 18px;
    }
  }
}
</style>