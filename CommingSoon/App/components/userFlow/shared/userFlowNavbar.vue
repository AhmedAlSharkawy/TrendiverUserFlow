<template>
  <div class="header">
    <b-navbar toggleable="lg" class="navigation d-flex">
      <img src="../../../../build/logo.png"/>
      <b-navbar-brand href="#">Trendiver</b-navbar-brand>
      <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
      <b-collapse id="nav-collapse" is-nav>
        <div class="header-search">
          <b-nav-form>
            <b-form-input size="sm" class="search-input" placeholder="Search"></b-form-input>
            <b-button size="sm" class="search-btn" type="submit">
              <i class="fa fa-search" aria-hidden="true"></i>
            </b-button>
          </b-nav-form>
        </div>
        <div class="btn-section d-flex">
          <b-button size="sm" class="header-btns" type="submit">Become a Creator</b-button>
          <div class="vertical-line"></div>
          <b-button size="sm" class="header-btns" type="submit">Login</b-button>
          <b-button size="sm" class="signup-btn" type="submit">Sign Up</b-button>
        </div>
      </b-collapse>
    </b-navbar>
  </div>
</template>

<style lang="less" scoped>
.header {
  .navigation {
    background: #f3f5f7;
    .header-search {
      margin:auto;
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
        width: 300px;
        @media only screen and (max-width: 600px) {
          width: 240px;
        }
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
    .btn-section {
      .header-btns {
        font-size: 16px;
        background: #f3f5f7;
        border: 1px solid #131333;
        margin: 0px 14px;
        color: #131333;
        border-radius: 8px;
      }
      .signup-btn {
        background: #feca55;
        border-radius: 8px;
        border: none;
        padding: 7px;
      }
      .vertical-line {
        border-left: 1px solid black;
        margin: 5px 0;
      }
    }
  }
}
</style>