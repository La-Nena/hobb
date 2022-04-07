<template>
 <form>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input v-model="email" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input v-model="password" type="password" class="form-control" id="exampleInputPassword1">
  </div>
  <div v-if="incorrectCredentials">YOU ENTERED WRONG CREDENTIALS IDIOT</div>
  <button type="button" class="btn btn-primary" @click="login()">Submit</button>
</form> 
</template>


<script>
import axios from 'axios';

export default {
  name: "LoginPage",
  data() {
    return {
      email: '',
      password: '',
      incorrectCredentials: false
    };
  },
  methods: {
    login(){
      axios.post('https://localhost:7254/api/Authentication/login', {
        email: this.email,
        password: this.password
      })
      .then(() => {
        console.log('IT WORKED');
      })
      .catch(() => {
        this.incorrectCredentials = true;
        console.log('IT DIDNT WORK :(');
      })
      .finally(() => {
        this.email = '';
        this.password = '';
        console.log('YOU ARE AWESOME, EVEN IF YOU FAILED OR NOT.');
      });
    }
  }
}
</script>