import { createRouter, createWebHistory } from "vue-router";
import LoginPage from './components/LoginPage.vue';
import MainPage from './components/MainPage.vue';

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/', component: MainPage },
        { path: '/Login', component: LoginPage },
      ]
  });

  export default router;