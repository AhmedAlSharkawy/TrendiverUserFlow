import Vue from 'vue';

//userFlow components
import userFlowNavbar from "./components/userFlow/shared/userFlowNavbar.vue";
import subNavbar from "./components/userFlow/shared/subNavbar.vue";
import sliderCard from "./components/userFlow/sliderCard.vue";
import footer from "./components/userFlow/shared/footer.vue";
import videoCard from "./components/userFlow/videoCard.vue";

//userFlow main pages
import homePage from "./components/userFlow/homePage.vue";


//userFlow
Vue.component("home-page",homePage);
Vue.component("uf-navbar", userFlowNavbar);
Vue.component("sub-navbar", subNavbar);
Vue.component("slider-card",sliderCard);
Vue.component("uf-footer", footer);
Vue.component("video-card", videoCard);