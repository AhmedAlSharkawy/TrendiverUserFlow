<template>
  <div class="table col-md-3">
    <p class="table-title pt-3">
      <b>Table of Content</b>
    </p>
    <!-- <div class="first-accordion">
      <div class="accordion1 d-flex flex-row">
        <p class="title pr-3" @click="show = !show">Section: title of this section</p>
        <i v-if="show" class="fa fa-angle-down fa-lg"></i>
        <i v-else class="fa fa-angle-up fa-lg"></i>
      </div>
      <div class="accordion1-content" v-if="show">
        <p>
          Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid.
          3 wolf moon officia aute, non cupidatat skateboard dolor brunch
        </p>
        <hr />
      </div>
    </div>-->
    <div id="accordion">
      <div id="headingOne">
        <h5 class="mb-0">
          <button
            class="btn btn-link title"
            data-toggle="collapse"
            data-target="#collapseOne"
            aria-expanded="true"
            aria-controls="collapseOne"
            @click="show = !show"
          >Section: title of this section</button>
          <i v-if="!show" class="fa fa-angle-up fa-lg"></i>
          <i v-else class="fa fa-angle-down fa-lg"></i>
        </h5>
      </div>
      <div
        id="collapseOne"
        class="collapse show"
        aria-labelledby="headingOne"
        data-parent="#accordion"
      >
        <div class="card-body">
          Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad
          squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.
          Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor,
          sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et.
          Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea
          proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table,
          raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore
          sustainable VHS.
        </div>
      </div>
      <hr />
      <div class="two">
        <div id="headingTwo">
          <h5 class="mb-0">
            <button
              class="btn btn-link collapsed"
              data-toggle="collapse"
              data-target="#collapseTwo"
              aria-expanded="false"
              aria-controls="collapseTwo"
              @click="show = true"
            >Section: title of this section</button>
            <i v-if="!show" class="fa fa-angle-up fa-lg"></i>
            <i v-else class="fa fa-angle-down fa-lg"></i>
          </h5>
        </div>
        <div
          id="collapseTwo"
          class="collapse"
          aria-labelledby="headingTwo"
          data-parent="#accordion"
        >
          <div
            class="card-body"
          >Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      show: false,
    };
  },
};
</script>

<style lang="less" scoped>
.table {
  background: #f3f5f7;
  border-radius: 8px;

  .title,
  .btn {
    cursor: pointer;
    color: #343a40;
    background-color: transparent;
    outline: none;
    border: none;
  }
  i {
    margin-top: 4px;
    color: #131333;
  }
}
</style>