<template>
  <div class="user-profile">
    <p class="page-title">
      <b>My Profile</b>
    </p>
    <p class="public-profile">Puplic Profile</p>

    <div class="profile-image d-flex flex-row">
      <div class="preview-img mr-4">
        <img svg-inline src="../../assets/addPhoto.svg" v-if="imageData.length == 0" />
        <img :src="imageData" />
      </div>

      <div class="upload-section d-flex flex-column">
        <p>
          <b>Your profile picture</b>
        </p>
        <label class="d-flex">
          <img svg-inline src="../../assets/upload.svg" />
          <p class="mb-0 pt-2">Upload</p>
          <input type="file" @change="previewImage" accept="image/*" />
        </label>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data: function () {
    return {
      imageData: "",
    };
  },
  methods: {
    previewImage: function (event) {
      var input = event.target;
      if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = (e) => {
          this.imageData = e.target.result;
        };
        reader.readAsDataURL(input.files[0]);
      }
    },
  },
};
</script>
<style lang="less" scoped>
.user-profile {
  padding-left: 20px;
  .page-title {
    font-size: 38px;
    @media only screen and (max-width: 600px) {
      font-size: 24px;
    }
  }
  .public-profile {
    font-size: 28px;
    @media only screen and (max-width: 600px) {
      font-size: 20px;
    }
  }
  .profile-image {
    .preview-img {
      display: flex;
      align-items: center;
      justify-content: center;
      border: 1px solid #9299a0;
      box-sizing: border-box;
      border-radius: 8px;
      width: 15%;
      height: 190px;
    }
    .upload-section {
      justify-content: center;
      p {
        font-size: 17px;
      }
      label {
        cursor: pointer;
        color: #3512b1;
      }
      input[type="file"] {
        display: none;
      }
    }
  }
}
</style>