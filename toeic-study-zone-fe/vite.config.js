import { defineConfig } from "vite";
import vue from "@vitejs/plugin-vue";
import path from "path";

export default defineConfig({
  plugins: [vue()],
  resolve: {
    alias: {
      "@": path.resolve(__dirname, "./src"),
    },
  },
  css: {
    preprocessorOptions: {
      scss: {
        // Nhập Bootstrap từ node_modules mà không cần đường dẫn dài trong main.scss
        additionalData: `@use "bootstrap/scss/bootstrap" as bootstrap;`,
        // Thêm node_modules vào danh sách đường dẫn tìm kiếm
        includePaths: ["node_modules"],
      },
    },
  },
});
