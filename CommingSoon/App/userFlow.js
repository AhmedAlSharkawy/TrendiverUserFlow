import Vue from "vue";
import "../node_modules/bootstrap/dist/css/bootstrap.css";
import "../node_modules/bootstrap-vue/dist/bootstrap-vue.css";

import App from "./App.vue";
import router from "./router";
import store from "./store";
import UFNavBar from "./userFlow/sharedComponents/UFNavBar.vue";
import {
  NavbarPlugin,
  DropdownPlugin,
  CollapsePlugin,
  FormInputPlugin,
  ButtonPlugin,
  BootstrapVue
} from "bootstrap-vue";

Vue.use(BootstrapVue);
Vue.use(NavbarPlugin);
Vue.use(DropdownPlugin);
Vue.use(CollapsePlugin);
Vue.use(FormInputPlugin);
Vue.use(ButtonPlugin);

Vue.component("UF-NavBar", UFNavBar);
Vue.config.productionTip = false;

new Vue({
  router,
  store,
  render: (h) => h(App),
}).$mount("#app");
