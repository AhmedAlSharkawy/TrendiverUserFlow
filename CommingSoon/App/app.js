import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import ContentProvider from './components/ContentProvider.vue'
import Traction from './components/Traction.vue'


Vue.component("content-provider", ContentProvider);
Vue.component("traction", Traction);

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
