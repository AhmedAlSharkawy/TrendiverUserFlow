 
<template>
    <div>
        {{providerDetails}}
        <table class="table table-bordered">
            <thead>
                <tr>
                <th scope="col">#</th>
                <th scope="col">Name</th>
                <th scope="col">Content Type</th>
                <th scope="col">Avg Price</th>
                <th scope="col">Content Number</th>
                <th scope="col">Avg Views</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">1</th>
                    <td>Mark</td>
                    <td>Otto</td>
                    <td>@mdo</td>
                    <td>1234</td>
                    <td>23</td>
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
    })
  },
   created: function() {
    this.getProviderDetails();
  }
}
</script>
