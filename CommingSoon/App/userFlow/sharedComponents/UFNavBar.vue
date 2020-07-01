<template>
  <div class="header">
    <nav class="navigation navbar navbar-expand-lg navbar-light bg-light">
      <div>
        <img src="../assets/logo.png" />
        <a class="navbar-brand" href="#">Trendiver</a>
      </div>

      <div
        class="collapsed-area collapse navbar-collapse d-flex justify-content-around"
        id="navbarTogglerDemo03"
      >
        <form class="header-search d-flex">
          <input type="text" placeholder="Search" />
          <button class="search-btn btn-submit" value="submit">
            <i class="fa fa-search" aria-hidden="true"></i>
          </button>
        </form>
        <ul class="navbar-nav">
          <li class="nav-item active">
            <a class="nav-link" href="#">
              Home
              <span class="sr-only">(current)</span>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Link</a>
          </li>
          <li class="nav-item">
            <a class="nav-link disabled" href="#">Disabled</a>
          </li>
        </ul>
      </div>
    </nav>
  </div>
</template>

<script>
export default {};
</script>

<style lang="less" scoped>
.header {
  .navigation {
    background: #F3F5F7;
    .navbar-brand {
      font-size: 14px;
      font-weight: bold;
    }
    .collapsed-area {
      .header-search {
         box-shadow: 0px 0px 5px rgba(19, 19, 51, 0.1);
        input {
          box-sizing: content-box;
          border-radius: 8px 0 0 8px;
          border: none;
          color: #6a6d75;
          padding: 10px 15px;
          margin-top: 0;
          background-color: #fff;
          height: 16px;
          line-height: 20px;
          font-size: 14px;
          width: 270px;
        }
        .search-btn {
          border-radius: 0 8px 8px 0;
          box-sizing: content-box;
          padding: 10px 15px;
          height: 16px;
          line-height: 20px;
          color: #fff;
          font-size: 15px;
          border: 0 none transparent;
          background-color: #3512B1;
        }
      }
    }
  }
}
</style>