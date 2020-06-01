import Vue from "vue";
import axios from "axios";

Vue.prototype.$http = axios;

export default {
  namespaced: true,
  state: {
    providerDetails: ""
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
    getRecipeDetails({ commit }) {
      return axios
        .get("http://localhost:4644/api/dashboard")
        .then(data => {
          commit("SET_PROVIDER_DETAILS", data);
        });
    }
  }
};
