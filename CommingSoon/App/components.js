import Vue from 'vue';

//userFlow
import userFlowNavbar from "./userFlow/sharedComponents/userFlowNavbar.vue";
import subNavbar from "./userFlow/sharedComponents/subNavbar.vue";
import sliderCard from "./userFlow/components/sliderCard.vue";


//userFlow
Vue.component("uf-navbar", userFlowNavbar);
Vue.component("sub-navbar", subNavbar);
Vue.component("slider-card",sliderCard);