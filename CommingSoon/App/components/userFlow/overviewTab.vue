<template>
  <div class="overview-tab col-md-9">
    <p class="overview-title">
      <b>Course overview</b>
    </p>
    <p class="overview-content">
      Lorem ipsum dolor sit amet, consectetur adipiscing elit.
      Non neque non nibh eget eu.Mauris eget sit libero scelerisque mauris cras orci.
      Lacus ultrices vitae enim augue mauris auctor consectetur tincidunt
    </p>
    <p class="learn-title">What you will learn</p>
    <div class="d-flex flex-row">
      <section class="d-flex flex-column">
        <img svg-inline src="../../assets/right.svg" />
        <img svg-inline class="mt-4" src="../../assets/Line.svg" />
      </section>
      <section class="d-flex flex-column pl-3">
        <p class="sub-title">
          <b>Business Strategy</b>
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Non neque non nibh eget eu.
          Mauris eget sit libero scelerisque mauris cras orci.
        </p>
      </section>
    </div>
    <br />
    <div class="d-flex flex-row">
      <section class="d-flex flex-column">
        <img svg-inline src="../../assets/right.svg" />
        <img svg-inline class="mt-4" src="../../assets/Line.svg" />
      </section>
      <section class="d-flex flex-column pl-3">
        <p class="sub-title">
          <b>Google Analytics</b>
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Non neque non nibh eget eu.
          Mauris eget sit libero scelerisque mauris cras orci.
        </p>
      </section>
    </div>
    <br />
    <div class="d-flex flex-row">
      <section class="d-flex flex-column">
        <img svg-inline src="../../assets/right.svg" />
        <img svg-inline class="mt-4" src="../../assets/Line.svg" />
      </section>
      <section class="d-flex flex-column pl-3">
        <p class="sub-title">
          <b>User Interviews</b>
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Non neque non nibh eget eu.
          Mauris eget sit libero scelerisque mauris cras orci.
        </p>
      </section>
    </div>
    <br />
    <div class="d-flex flex-row">
      <section class="d-flex flex-column">
        <img svg-inline src="../../assets/right.svg" />
        <img svg-inline class="mt-4" src="../../assets/Line.svg" />
      </section>
      <section class="d-flex flex-column pl-3">
        <p class="sub-title">
          <b>User Testing</b>
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Non neque non nibh eget eu.
          Mauris eget sit libero scelerisque mauris cras orci.
        </p>
      </section>
    </div>
    <!--Requirments-->
    <div class="requirments">
      <p class="requirments-title">Requirments</p>
      <div>
        <ul class="requirments-list pl-3">
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
        </ul>
      </div>
    </div>
    <!--this course for-->
    <div class="course-section">
      <p class="course">This course for :</p>
      <p>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
        Non neque non nibh eget eu. Mauris eget sit libero scelerisque mauris cras orci.
      </p>
      <div>
        <ul class="course-list pl-3">
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
          <li>
            <span>Lorem ipsum dolor sit amet.</span>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>

<style lang="less" scoped>
.overview-tab {
  .overview-title,
  .learn-title,
  .requirments-title,
  .course {
    font-size: 32px;
    color: #21252a;
  }
  .sub-title {
    font-size: 18px;
  }
  .requirments {
    .requirments-list {
      li {
        color: #3512b1;
        margin-bottom: 10px;
      }
      span {
        color: #343a40;
        font-size: 18px;
      }
    }
  }
  .course-section {
    .course-list {
      li {
        color: #3512b1;
        margin-bottom: 10px;
      }
      span {
        color: #343a40;
        font-size: 18px;
      }
    }
  }
}
</style> 