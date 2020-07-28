import Vue from 'vue'
import VueRouter from 'vue-router'
import homePage from '../components/userFlow/homePage.vue'
import categoriesPage from '../components/userFlow/categoriesPage.vue'

Vue.use(VueRouter)

  const routes = [
  {
    path: '/homePage',
    name: 'homePage',
    component: homePage
  },
  {
    path: '/categoriesPage',
    name: 'categoriesPage',
    component: categoriesPage
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
