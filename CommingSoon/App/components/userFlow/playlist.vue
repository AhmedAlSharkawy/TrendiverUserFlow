<template>
  <div class="playlist col-md-3">
    <section class="d-flex flex-row justify-content-between">
    <p class="playlist-title pt-3">
      <b>Playlist</b>
    </p>
    <img svg-inline class="header-play" src="../../assets/playlist.svg" />
    </section>
    <div class="d-flex flex-row">
      <img class="video-img" src="App/assets/meeting.png" />
      <section class="d-flex flex-column pl-2">
        <a class="video-title" href="#">
          Title of the video we can add more text
        </a>
        <section class="d-flex flex-row justify-content-between">
        <p class="time mt-3">3:54 Mins</p>
        <img class="play-video" src="App/assets/playVideo.png" />
        </section>
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
  background: #F3F5F7;
  border-radius: 8px;
  .playlist-title {
    color: #21252a;
  }
  .header-play {
    margin-top: 17px;
  }
  .video-img {
    height: fit-content;
  }
  .video-title {
    font-size: 14px;
    color: #21252a;
    &:active {
      color: #3512B1;
    }
  }
  .play-video {
    width: fit-content;
    height: fit-content;
    margin-top: 11px;
  }
  .time {
      font-size: 12px;
      color: #495057;
  }
}
</style>