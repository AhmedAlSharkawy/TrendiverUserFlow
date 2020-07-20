<template>
  <div>
    <div class="card">
      <img class="card-img-top" src alt="Card image cap" />
      <div class="card-body">
        <p class="sub-title">Recorded</p>
        <p class="card-title">Business Analytics</p>
        <div class="card-content d-flex flex-row">
          <img src="#" />
          <p class="card-content-text">Moo Islam</p>
        </div>
        <p class="card-price">EGP 1090</p>
      </div>
    </div>
  </div>
</template>

<style lang="less" scoped>
.card {
  box-shadow: 0px 0px 8px rgba(19, 19, 51, 0.15);
  border-radius: 8px;
  width: 17rem;
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