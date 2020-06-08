<template>
  <div id="app">
    <div class="d-flex flex-column" id="nav">
      <traction></traction>
      <div class="d-flex align-self-center flex-column">
        <button class="align-self-center btn btn-default" @click="seen = !seen">Advanced</button>
        <p v-if="seen">
          <content-provider></content-provider>
        </p>
      </div>
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
button {
  width: fit-content;
  margin: 20px;
}
</style>