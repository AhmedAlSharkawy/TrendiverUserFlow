<template>
  <div>
    <div class="" id="nav">
      <UF-NavBar></UF-NavBar>
      <!-- <div class="row">
        <div class="traction col-12">
          <traction></traction>
        </div>
        <div class="col-12">
          <div class="d-flex align-self-center flex-column w-100">
            <button class="align-self-center btn btn-default" @click="seen = !seen">Advanced</button>
            <p v-if="seen">
              <content-provider></content-provider>
            </p>
          </div>
        </div>
      </div> -->
    </div>
    <router-view />
  </div>
</template>

<script>

export default {
  data() {
    return {
      seen: false
    };
  },
};
</script>

<style lang="less" scoped>
.traction {
  box-sizing: border-box;
}
button {
  width: fit-content;
  margin: 20px;
}
</style>