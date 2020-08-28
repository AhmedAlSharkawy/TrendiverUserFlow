<template>
  <div class="instructor-tab col-md-9">
    <p class="tab-title">Overview about the provider</p>
    <p class="content">
      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Non neque non nibh eget eu.
      Mauris eget sit libero scelerisque mauris cras orci.
      Lacus ultrices vitae enim augue mauris auctor consectetur tincidunt.
    </p>
    <div class="instructor-section">
      <p class="title pb-5">Our Instructors</p>
      <section class="instructor-cards d-flex flex-row">
        <instructor-card></instructor-card>
        <instructor-card></instructor-card>
      </section>
    </div>
  </div>
</template>


<style lang="less" scoped>
.instructor-tab {
  .tab-title,
  .title {
      color: #131333;
      font-size: 30px;
        @media only screen and (max-width: 600px) {
            font-size: 23px;
        }
  }
}
</style>