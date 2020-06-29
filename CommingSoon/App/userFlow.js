import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import header from './userFlow/sharedComponents/header.vue'

Vue.component('header', header);

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
