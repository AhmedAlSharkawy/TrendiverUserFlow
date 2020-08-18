<template>
  <div class="provider-card col-md-4 mb-md-0 mb-2">
    <div class="card-content p-3">
      <img class="provider-photo" src="App/assets/provider.png" />
      <p class="card-title pt-5">
        <b>IIP Institute</b>
      </p>
      <p class="card-sub-title">
        <b>Bussines, Design, Dvelopment</b>
      </p>
      <div class="provider-numbers d-flex flex-row flex-wrap justify-content-between">
        <p>
          <b>14</b> Course
        </p>
        <p>
          <b>2</b> Webinar
        </p>
        <p>
          <b>2</b> Livestream
        </p>
        <p>
          <b>25k</b> viewers
        </p>
      </div>
    </div>
  </div>
</template>


<style lang="less" scoped>
.provider-card {
  position: relative;
  .card-content {
    background-color: #f3f5f7;
    box-shadow: 0px 0px 8px rgba(19, 19, 51, 0.15);
    border-radius: 8px;
    .card-title {
      color: #3512b1;
    }
    .card-sub-title {
      color: #21252a;
    }
    .provider-numbers {
     color: #343A40;
    }
  }
  .provider-photo {
    position: absolute;
    top: -67px;
  }
}
</style>