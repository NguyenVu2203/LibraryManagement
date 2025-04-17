import { createRouter, createWebHistory } from "vue-router";
import Home from "@/views/Home.vue"; // Import Home.vue
import authRoutes from "./auth";

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home,
    meta: { layout: "default" }, // Sử dụng DefaultLayout cho trang chủ
  },
  ...authRoutes, // Spread các route từ authRoutes
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
