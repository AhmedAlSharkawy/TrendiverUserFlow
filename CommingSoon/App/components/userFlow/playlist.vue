<template>
  <div class="playlist col-md-3">
    <p class="playlist-title pt-3">
      <b>Playlist</b>
    </p>
    <div class="d-flex flex-row">
      <img class="video-img" src="App/assets/meeting.png" />
      <section class="d-flex flex-column pl-2">
        <a class="video-title" href="#">
          Title of the video we can add more text
        </a>
        <p class="time mt-3">3:54 Mins</p>
      </section>
    </div>
    <hr />
    <div class="d-flex flex-row">
      <img class="video-img" src="App/assets/meeting.png" />
      <section class="d-flex flex-column pl-2">
        <a class="video-title" href="#">
          Title of the video we can add more text
        </a>
        <p class="time mt-3">3:54 Mins</p>
      </section>
    </div>
    <hr/>
    <div class="d-flex flex-row">
      <img class="video-img" src="App/assets/meeting.png" />
      <section class="d-flex flex-column pl-2">
        <a class="video-title" href="#">
          Title of the video we can add more text
        </a>
        <p class="time mt-3">3:54 Mins</p>
      </section>
    </div>
  </div>
</template>


<style lang="less" scoped>
.playlist {
  background: #e5e5e5;
  border-radius: 8px;
  .playlist-title {
    color: #21252a;
  }
  .video-img {
    height: fit-content;
  }
  .video-title {
    font-size: 14px;
    color: #21252a;
  }
  .time {
      font-size: 12px;
      color: #495057;
  }
}
</style>