import Vue from "vue";
import axios from "axios";

Vue.prototype.$http = axios;

export default {
  namespaced: true,
  state: {
    providerDetails: [{}]
  },
  getters: {
    providerDetails(state) {
      return state.providerDetails;
    }
  },
  mutations: {
    ["SET_PROVIDER_DETAILS"](state, providerDetails) {
      state.providerDetails = providerDetails.data;
    
      return providerDetails;
    }
  },
  actions: {
    getProviderDetails({ commit }) {
      return axios
        .get("https://www.trendiver.com/api/dashboard")
        .then(data => {
          commit("SET_PROVIDER_DETAILS", data);
        })
        .catch(error => {
            console.log(error);
          })
    },
  }
};
