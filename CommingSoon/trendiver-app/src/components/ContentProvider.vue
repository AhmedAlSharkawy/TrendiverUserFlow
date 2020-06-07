 
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
                <tr v-for="(provider, key , i) in getAllElements()"
                 :key="key">
                    {{i}}
                    <td>{{ provider.Name }}</td>
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
    getAllElements() {
      return this.providerDetails.ContentPublishers_All
    }
  },
   created: function() {
    this.getProviderDetails();
  }
}
</script>
