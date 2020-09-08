<template>
  <div class="content-tabs col-md-9 p-0">
    <nav>
      <div class="nav nav-tabs" id="nav-tab" role="tablist">
        <a
          class="nav-item nav-link active"
          id="nav-chat-tab"
          data-toggle="tab"
          href="#nav-chat"
          role="tab"
          aria-controls="nav-chat"
          aria-selected="true"
        >Chat</a>
        <a
          class="nav-item nav-link"
          id="nav-profile-tab"
          data-toggle="tab"
          href="#nav-profile"
          role="tab"
          aria-controls="nav-profile"
          aria-selected="false"
        >Assignments</a>
        <a
          class="nav-item nav-link d-sm-block d-md-none"
          id="nav-document-tab"
          data-toggle="tab"
          href="#nav-document"
          role="tab"
          aria-controls="nav-document"
          aria-selected="false"
        >Documents</a>
        <a
          class="nav-item nav-link"
          id="nav-contact-tab"
          data-toggle="tab"
          href="#nav-contact"
          role="tab"
          aria-controls="nav-contact"
          aria-selected="false"
        >FAQs</a>
      </div>
    </nav>
    <div class="tab-content" id="nav-tabContent">
      <div
        class="tab-pane fade show active"
        id="nav-chat"
        role="tabpanel"
        aria-labelledby="nav-chat-tab"
      >...</div>
      <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab">
        <p class="assignmets-tab mt-4">
          <b>Assignments</b>
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit.
          Non neque non nibh eget eu. Mauris eget sit libero scelerisque mauris cras orci.
        </p>
        <div>
          <ul class="assignmets-list pl-3">
            <li>
              <span>Lorem ipsum dolor sit amet.</span>
            </li>
            <li>
              <span>Lorem ipsum dolor sit amet.</span>
            </li>
            <li>
              <span>Lorem ipsum dolor sit amet.</span>
            </li>
            <li>
              <span>Lorem ipsum dolor sit amet.</span>
            </li>
          </ul>
        </div>
      </div>
      <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab">
        <div id="accordion">
          <div id="headingOne">
            <h5 class="mb-0 pt-4">
              <button
                class="btn btn-link title"
                data-toggle="collapse"
                data-target="#collapseOne"
                aria-expanded="true"
                aria-controls="collapseOne"
                @click="show = !show"
              >Section: title of this section</button>
              <i v-if="!show" class="fa fa-angle-up fa-lg"></i>
              <i v-else class="fa fa-angle-down fa-lg"></i>
            </h5>
          </div>
          <div
            id="collapseOne"
            class="collapse show"
            aria-labelledby="headingOne"
            data-parent="#accordion"
          >
            <div class="card-body">
              Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad
              squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.
              Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor,
              sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et.
              Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea
              proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table,
              raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore
              sustainable VHS.
            </div>
          </div>
          <hr />
          <div class="two">
            <div id="headingTwo">
              <h5 class="mb-0">
                <button
                  class="btn btn-link title collapsed"
                  data-toggle="collapse"
                  data-target="#collapseTwo"
                  aria-expanded="false"
                  aria-controls="collapseTwo"
                  @click="show = true"
                >Section: title of this section</button>
                <i v-if="!show" class="fa fa-angle-up fa-lg"></i>
                <i v-else class="fa fa-angle-down fa-lg"></i>
              </h5>
            </div>
            <div
              id="collapseTwo"
              class="collapse"
              aria-labelledby="headingTwo"
              data-parent="#accordion"
            >
              <div class="card-body">
                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad
                squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa
                nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid
                single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft
                beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher
                vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt
                you probably haven't heard of them accusamus labore sustainable VHS.
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="tab-pane fade" id="nav-document" role="tabpanel" aria-labelledby="nav-document-tab">
        <section class="documents-section d-flex flex-column p-3">
          <a href="#">Video Slides [pdf]</a>
          <a href="#">Interview Questions [pdf]</a>
          <a href="#">Game Plan [pdf]</a>
        </section>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      show: false,
    };
  },
};
</script>

<style lang="less" scoped>
.content-tabs {
  .nav-tabs {
    a {
      color: #9299a0;
      &:active {
        color: #3512b1;
      }
    }
    .nav-link {
      border: none;
      &:active {
        color: #3512b1;
        border-color: white white #dee2e6;
        background-color: none;
      }
      @media only screen and (max-width: 600px) {
        padding: 0.5rem 0.5rem;
      }
    }
    .nav-item {
      margin-bottom: 0;
    }
  }
  .assignmets-tab {
    font-size: 32px;
    color: #21252a;
  }
  .assignmets-list {
    li {
      color: #3512b1;
      margin-bottom: 10px;
      font-size: larger;
    }
    span {
      color: #343a40;
      font-size: 18px;
    }
  }
  .tab-content {
    .tab-pane {
      #accordion {
        background-color: #f3f5f7;
        border-radius: 8px;
        .title {
          color: #000000;
          font-size: 20px;
          text-decoration: none;
        }
      }
      .documents-section {
        background: #f3f5f7;
        border-radius: 8px;
        a {
          color: #343a40;
          margin-bottom: 5px;
        }
      }
    }
  }
}
</style>