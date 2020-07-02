<template>
  <div class="header">
    <b-navbar toggleable="lg" class="navigation">
      <img src="../../../../CommingSoon/logo.png" />
      <b-navbar-brand href="#">Trendiver</b-navbar-brand>

      <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

      <b-collapse id="nav-collapse" is-nav>
        <!-- Right aligned nav items -->
        <b-navbar-nav class="m-auto">
          <b-nav-form class="header-search">
            <b-form-input size="sm" class="search-input" placeholder="Search"></b-form-input>
            <b-button size="sm" class="search-btn" type="submit">
              <i class="fa fa-search" aria-hidden="true"></i>
            </b-button>
          </b-nav-form>

  
        </b-navbar-nav>
        <b-button size="sm" type="submit">Become a Creator</b-button>
          <b-button size="sm" type="submit">Login</b-button>

          <b-button size="sm"  type="submit">Sign Up</b-button>
      </b-collapse>
    </b-navbar>
  </div>
</template>

<script>
export default {};
</script>

<style lang="less" scoped>
.header {
  .navigation {
    background: #f3f5f7;
      .search-input {
        box-sizing: content-box;
        box-shadow: 0px 0px 5px rgba(19, 19, 51, 0.1);
        border-radius: 8px 0 0 8px;
        border: none;
        color: #6a6d75;
        padding: 10px 15px;
        background-color: #fff;
        height: 16px;
        line-height: 20px;
        font-size: 14px;
        width: 270px;
      }
      .search-btn {
        border-radius: 0 8px 8px 0;
        box-shadow: 0px 0px 5px rgba(19, 19, 51, 0.1);
        box-sizing: content-box;
        padding: 10px 15px;
        height: 16px;
        line-height: 20px;
        color: #fff;
        font-size: 15px;
        border: 0 none transparent;
        background-color: #3512b1;
      }
    }
  }
</style>