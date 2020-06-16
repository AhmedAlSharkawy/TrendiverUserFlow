<template>
  <div class="dashboard w-100">
    <div class="dashboard-container">
      <section class="dashboard-icons">
        <img svg-inline class="svg-img" src="../assets/Provider.svg" />
        <p class="icon-title">Content Providers</p>
        <p class="dashboard-number">{{ providerDetails.ContentProviders }}</p>
      </section>
      <section class="dashboard-icons">
        <img svg-inline class="svg-img" src="../assets/Content.svg" />
        <p class="icon-title">Contents</p>
        <p class="dashboard-number">{{providerDetails.Contents}}</p>
      </section>
      <section class="dashboard-icons">
        <img svg-inline class="svg-img" src="../assets/PriceContent.svg" />
        <p class="icon-title">Avg Price/Content</p>
        <p class="dashboard-number">{{providerDetails.AvgPricePerContent}}</p>
      </section>
    </div>
    <div class="dashboard-container">
      <section class="dashboard-icons">
        <img svg-inline class="svg-img" src="../assets/ViewersContent.svg" />
        <p class="icon-title">
          Avg Estimated
          <br />Viewers/Content
        </p>
        <p class="dashboard-number">{{providerDetails.AvgEstimatedViewersPerContent}}</p>
      </section>
      <section class="dashboard-icons">
        <img svg-inline class="svg-img" src="../assets/Revenue.svg" />
        <p class="icon-title">
          Total Estimated
          <br />Revenue
        </p>
        <p class="dashboard-number">{{providerDetails.TotalEstimatedRevenue}}</p>
      </section>
      <section class="dashboard-icons">
        <img svg-inline class="svg-img" src="../assets/CommissionRevenue.svg" />
        <p class="icon-title">
          Commission Net
          <br />Revenue (EBTDA)
        </p>
        <p class="dashboard-number">{{providerDetails.CommissionNet}}</p>
      </section>
    </div>
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
};
</script>

 <style lang="less" scoped>
.dashboard {
  border: 1px solid #9e9e9e80;
  margin: auto;
  border-radius: 10px;
  box-shadow: 0 3px 7px 1px #dfdfdf;
  margin-top: 15px;
  .dashboard-container {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    .dashboard-icons {
      display: flex;
      flex-direction: column;
      justify-content: center;
      margin: 20px;
      .svg-img {
       display: flex;
       align-self: center;
      }
      .icon-title {
        text-align: center;
        margin: auto 0;
        padding: 10px;
      }
      .dashboard-number {
        text-align: center;
      }
    }
  }
   @media only screen and (max-width: 600px) {
    padding: 10px 0;
    .dashboard-container {
      .dashboard-icons {
         margin: 0;
         .icon-title {
           padding: 6px;
         }
      }
    }
  }
}
</style>