import Vue from 'vue'
import VueRouter from 'vue-router'
import ContentProvider from '../components/ContentProvider'
Vue.use(VueRouter)

  const routes = [
  {
    path: '/ContentProvider',
    name: 'ContentProvider',
    component: ContentProvider
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
