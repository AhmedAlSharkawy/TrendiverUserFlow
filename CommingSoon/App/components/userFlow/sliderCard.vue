<template>
  <div class="cards-section justify-content-between">
    <div class="card col-md-4 pl-0">
      <section class="card-content p-2">
        <img svg-inline class="card-icon" src="../../assets/clock.svg" />
        <p class="card-title">Unlimited Access</p>
        <p>
          self-based learning - whenever and wherever
          you want. Graduate while learning part-time
          for 10hrs/week.
        </p>
      </section>
    </div>
    <div class="card col-md-4">
      <section class="card-content p-2">
        <img svg-inline class="card-icon" src="../../assets/graduation.svg" />
        <p class="card-title">Interaction Learning</p>
        <p>
          self-based learning - whenever and wherever
          you want. Graduate while learning part-time
          for 10hrs/week.
        </p>
      </section>
    </div>
    <div class="card col-md-4">
      <section class="card-content p-2">
        <img svg-inline class="card-icon" src="../../assets/money.svg" />
        <p class="card-title">Save Money</p>
        <p>
          self-based learning - whenever and wherever
          you want. Graduate while learning part-time
          for 10hrs/week.
        </p>
      </section>
    </div>
  </div>
</template>


<style lang="less" scoped>
.cards-section {
  display: flex;
  flex-direction: row;
  @media only screen and (max-width: 600px) {
    flex-direction: column;
    margin: 0.5rem;
  }
  .card {
    display: flex;
    flex-direction: column;
    text-align: center;
    border: 0;
    @media only screen and (max-width: 600px) {
      margin-bottom: 5px;
    }
    .card-content {
      box-shadow: 0px 0px 5px rgba(19, 19, 51, 0.1);
      border-radius: 8px;
    }
    .card-icon {
      align-self: center;
      margin: 20px;
    }
    .card-title {
      font-size: 22px;
      color: #3512b1;
    }
  }
}
</style>