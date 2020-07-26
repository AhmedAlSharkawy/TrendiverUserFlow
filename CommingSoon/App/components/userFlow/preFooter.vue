<template>
  <div class="pre-footer-section">
    <img class="background-img" svg-inline src="../../assets/Background.svg" />
    <div class="pre-footer container">
      <div class="pre-footer-content">
        <h1 class="mb-4">
          <b>Record, Upload, Monetize</b>
        </h1>
        <p>
          A paragraph is a series of related sentences developing a central idea, called the topic.
          Try to think about
          <br />paragraphs in terms of thematicunity: a paragraph is a sentence or a group of
          sentences that supports.
        </p>
        <button class="creator-btn mt-4" type="submit"><b>Become a Creator</b></button>
      </div>
    </div>
    <img class="instructor-img" src="../../assets/instructor.png"/>
  </div>
</template>


<style lang="less" scoped>
.pre-footer-section {
  position: relative;
  .background-img {
    width: 100%;
    height: auto;
  }
  .pre-footer {
    .pre-footer-content {
      top: 100px;
      color: #f8f7fd;
      position: absolute;
      line-height: 2.5;
    }
    .creator-btn {
      background: #feca55;
      border-radius: 8px;
      border: none;
      padding: 2px 30px;
      color: #FFFFFF;
    }
  }
}
</style>