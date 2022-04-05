<template>
  <div>
    <img alt="Panda logo" src="../assets/pandita.png" />
    Welcome!
  </div>

  <button type="button" class="btn btn-primary" @click="goToLoginPage()">
    Login
  </button>
</template>

<script>
export default {
  name: "MainPage",
  methods: {
    goToLoginPage() {
      this.$router.push("/Login");
    },
  },
};
</script>