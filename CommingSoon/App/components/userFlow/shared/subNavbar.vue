<template>
  <div class="sub-navbar d-flex flex-row">
    <a href="#">Home</a>
    <a href="#">Entertainment</a>
    <a href="#">Science&Knowledge</a>
    <a href="#">Health&Wellness</a>
    <a href="#">Arts&Literature</a>
  </div>
</template>


<style lang="less" scoped>
.sub-navbar {
  background: #e7ebee;
  a {
    text-decoration: none;
    color: #495057;
    font-size: 16px;
    margin: 8px;
    padding: 0 14px;
    &:active {
      color: #3512b1;
    }
    @media only screen and (max-width: 600px) {
      padding: 0;
    }
  }
  @media only screen and (max-width: 600px) {
    overflow-x: scroll;
  }
}
</style>