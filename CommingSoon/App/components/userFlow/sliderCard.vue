<template>
  <div class="d-flex flex-row justify-content-around">
    <div class="card d-flex flex-column col-3">
      <img svg-inline class="card-icon" src="../../assets/clock.svg" />
      <p class="card-title">Unlimited Access</p>
      <p>
        self-based learning - whenever and wherever
        you want. Graduate while learning part-time
        for 10hrs/week.
      </p>
    </div>
    <div class="card d-flex flex-column col-3">
      <img svg-inline class="card-icon" src="../../assets/graduation.svg" />
      <p class="card-title">Interaction learning </p>
      <p>
        self-based learning - whenever and wherever
        you want. Graduate while learning part-time
        for 10hrs/week.
      </p>
    </div>
    <div class="card d-flex flex-column col-3">
      <img svg-inline class="card-icon" src="../../assets/money.svg" />
      <p class="card-title">Save Money</p>
      <p>
        self-based learning - whenever and wherever
        you want. Graduate while learning part-time
        for 10hrs/week.
      </p>
    </div>
  </div>
</template>


<style lang="less" scoped>
.card {
  box-shadow: 0px 0px 5px rgba(19, 19, 51, 0.1);
  text-align: center;
  border-radius: 8px;
  .card-icon {
    align-self: center;
    margin: 20px;
  }
  .card-title {
    font-size: 22px;
    color: #3512b1;
  }
}
</style>