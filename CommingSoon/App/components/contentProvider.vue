 
<template>
  <div>
    <table class="table table-bordered">
      <thead>
        <tr>
          <th scope="col">Name</th>
          <th scope="col">Content Type</th>
          <th scope="col">Avg Price</th>
          <th scope="col">Content Number</th>
          <th scope="col">Avg Views</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(provider, key , i) in getAllProviders()" :key="key">
          {{i}}
          <td>{{ key + 1 }} - {{ provider.Name }}</td>
          <td>{{ provider.ContentType }}</td>
          <td>{{ provider.PriceAvg }}</td>
          <td>{{ provider.ContentNumber }}</td>
          <td>{{ provider.ViewwesAvg }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>


<script>
import { mapGetters, mapActions } from "vuex";

export default {
  computed: {
    ...mapGetters({
      providerDetails: "ProviderDetails/providerDetails"
    })
  },
  methods: {
    ...mapActions({
      getProviderDetails: "ProviderDetails/getProviderDetails"
    }),
    getAllProviders() {
      return this.providerDetails.ContentPublishers_All;
    }
  },
  created: function() {
    this.getProviderDetails();
  }
};
</script>
