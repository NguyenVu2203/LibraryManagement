<template>
  <nav class="navbar navbar-expand-lg navbar-light bg-white shadow-sm">
    <div class="container">
      <router-link class="navbar-brand" to="/">
        <img :src="logo" alt="Study4 Logo" class="logo" />
      </router-link>
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarNav"
        aria-controls="navbarNav"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav ms-auto">
          <li class="nav-item">
            <router-link class="nav-link" to="/">Khóa học</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/tests">Luyện đề</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/flashcards"
              >Giới thiệu</router-link
            >
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/blog"
              >Kiểm tra đầu vào</router-link
            >
          </li>
          <!-- Hiển thị nút Đăng nhập ngay từ đầu -->
          <li class="nav-item login-button">
            <router-link
              class="nav-link btn btn-primary text-white px-3 py-2"
              to="/login"
              v-if="!isLoggedIn"
            >
              Đăng nhập
            </router-link>
          </li>
          <li class="nav-item dropdown" v-if="isLoggedIn">
            <a
              class="nav-link dropdown-toggle"
              href="#"
              id="navbarDropdown"
              role="button"
              data-bs-toggle="dropdown"
              aria-expanded="false"
            >
              <img :src="userAvatar" alt="User Avatar" class="user-avatar" />
            </a>
            <ul
              class="dropdown-menu dropdown-menu-end"
              aria-labelledby="navbarDropdown"
            >
              <li>
                <router-link class="dropdown-item" to="/profile"
                  >Hồ sơ</router-link
                >
              </li>
              <li>
                <router-link class="dropdown-item" to="/logout"
                  >Đăng xuất</router-link
                >
              </li>
            </ul>
          </li>
        </ul>
      </div>
    </div>
  </nav>
</template>

<script setup>
import { ref, onMounted } from "vue";

// Sử dụng placeholder nếu chưa có hình ảnh
const logo = "https://via.placeholder.com/40x40?text=Logo";
const userAvatar = "https://via.placeholder.com/32x32?text=User";

// Mô phỏng trạng thái đăng nhập (thay bằng logic thực tế khi có BE)
const isLoggedIn = ref(false);

// Để kiểm tra trạng thái đăng nhập khi component được tạo
onMounted(() => {
  console.log("Trạng thái đăng nhập:", isLoggedIn.value);
  // Đảm bảo Bootstrap JS được khởi tạo
  if (typeof bootstrap !== "undefined") {
    const dropdownElementList = document.querySelectorAll(".dropdown-toggle");
    dropdownElementList.forEach((element) => {
      new bootstrap.Dropdown(element);
    });
  }
});
</script>

<style lang="scss" scoped>
.navbar {
  padding: 1rem 0;
  position: relative;
  z-index: 1000;
}

.logo {
  height: 40px;
}

.nav-link {
  font-size: 1rem;
  font-weight: 500;
  color: #1c2526;
  margin-left: 1rem;
}

.nav-link:hover {
  color: #1877f2;
}

.user-avatar {
  width: 32px;
  height: 32px;
  border-radius: 50%;
}

/* Đảm bảo nút đăng nhập luôn hiển thị */
.login-button {
  display: block !important;
}

.btn-primary {
  background-color: #1877f2;
  border-color: #1877f2;
  display: inline-block !important;
  visibility: visible !important;
  opacity: 1 !important;
}

/* Đảm bảo hiển thị đúng trên các kích thước màn hình */
@media (max-width: 992px) {
  .navbar-nav {
    padding-top: 1rem;
  }

  .nav-item {
    margin-bottom: 0.5rem;
  }

  .login-button {
    margin-top: 0.5rem;
  }
}
</style>
