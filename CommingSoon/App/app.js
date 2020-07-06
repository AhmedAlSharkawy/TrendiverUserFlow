import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import contentProvider from './components/contentProvider.vue'
import traction from './components/traction.vue'


Vue.component("content-provider", contentProvider);
Vue.component("traction", traction);

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
