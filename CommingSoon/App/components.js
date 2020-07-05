import Vue from 'vue';

//userFlow
import userFlowNavbar from "./userFlow/shared/userFlowNavbar.vue";
import subNavbar from "./userFlow/shared/subNavbar.vue";
import sliderCard from "./userFlow/components/sliderCard.vue";


//userFlow
Vue.component("uf-navbar", userFlowNavbar);
Vue.component("sub-navbar", subNavbar);
Vue.component("slider-card",sliderCard);