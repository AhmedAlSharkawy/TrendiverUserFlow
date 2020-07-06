import Vue from 'vue';

//userFlow
import userFlowNavbar from "./components/userFlow/shared/userFlowNavbar.vue";
import subNavbar from "./components/userFlow/shared/subNavbar.vue";
import sliderCard from "./components/userFlow/sliderCard.vue";
import footer from "./components/userFlow/shared/footer.vue";


//userFlow
Vue.component("uf-navbar", userFlowNavbar);
Vue.component("sub-navbar", subNavbar);
Vue.component("slider-card",sliderCard);
Vue.component("uf-footer", footer);