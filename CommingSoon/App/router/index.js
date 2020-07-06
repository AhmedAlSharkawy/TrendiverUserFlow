import Vue from 'vue'
import VueRouter from 'vue-router'
import contentProvider from '../components/contentProvider.vue'

Vue.use(VueRouter)

  const routes = [
  {
    path: '/ContentProvider',
    name: 'ContentProvider',
    component: contentProvider
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
