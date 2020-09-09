<template>
  <div class="content-video">
    <p class="title">
      <b>Business Analytics for Begginers</b>
    </p>
    <div class="d-flex flex-row">
      <img svg-inline class="mr-2" src="../../assets/userPhoto.svg" />
      <p class="mb-0">
        <b>Moo Islam</b>
      </p>
    </div>
    <video class="mt-4" controls>
      <source src="mov_bbb.mp4" type="video/mp4" />
      <source src="mov_bbb.ogg" type="video/ogg" />Your browser does not support HTML5 video.
    </video>
  </div>
</template>


<style lang="less" scoped>
.content-video {
  .title {
    font-size: 32px;
    color: #3512b1;
    @media only screen and (max-width: 600px) {
      font-size: 18px;
    }
  }
  video {
    width: 700px;
    border-radius: 8px;
    @media only screen and (max-width: 600px) {
      width: 330px;
    }
  }
}
</style>