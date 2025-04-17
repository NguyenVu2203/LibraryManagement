<template>
  <form @submit.prevent="handleSubmit">
    <div class="row">
      <div class="col-md-6 mb-3">
        <input
          type="text"
          v-model="form.first_name"
          class="form-control"
          placeholder="Họ *"
          required
        />
      </div>
      <div class="col-md-6 mb-3">
        <input
          type="text"
          v-model="form.last_name"
          class="form-control"
          placeholder="Tên *"
          required
        />
      </div>
    </div>

    <div class="mb-3">
      <input
        type="email"
        v-model="form.email"
        class="form-control"
        placeholder="Email *"
        required
      />
    </div>

    <div class="mb-3 position-relative">
      <input
        :type="showPassword ? 'text' : 'password'"
        v-model="form.password"
        class="form-control"
        placeholder="Mật khẩu *"
        required
      />
      <span class="eye-icon" @click="togglePasswordVisibility">
        <i :class="showPassword ? 'fas fa-eye-slash' : 'fas fa-eye'"></i>
      </span>
    </div>

    <div class="mb-3 position-relative">
      <input
        :type="showConfirmPassword ? 'text' : 'password'"
        v-model="form.confirm_password"
        class="form-control"
        placeholder="Nhập lại mật khẩu *"
        required
      />
      <span class="eye-icon" @click="toggleConfirmPasswordVisibility">
        <i :class="showConfirmPassword ? 'fas fa-eye-slash' : 'fas fa-eye'"></i>
      </span>
    </div>

    <div class="mb-3">
      <label class="form-label">
        Ngày sinh *<span class="info-icon">ⓘ</span>
      </label>
      <div class="row">
        <div class="col">
          <select v-model="form.day" class="form-select" required>
            <option value="" disabled>Ngày</option>
            <option v-for="day in 31" :key="day" :value="day">{{ day }}</option>
          </select>
        </div>
        <div class="col">
          <select v-model="form.month" class="form-select" required>
            <option value="" disabled>Tháng</option>
            <option v-for="month in 12" :key="month" :value="month">
              {{ month }}
            </option>
          </select>
        </div>
        <div class="col">
          <select v-model="form.year" class="form-select" required>
            <option value="" disabled>Năm</option>
            <option v-for="year in years" :key="year" :value="year">
              {{ year }}
            </option>
          </select>
        </div>
      </div>
    </div>

    <button type="submit" class="btn btn-success w-100">Đăng ký</button>
    <div class="text-center">
      <p>
        Đã có tài khoản?
        <router-link to="/login" class="text-decoration-none">
          Đăng nhập
        </router-link>
      </p>
    </div>
  </form>
</template>

<script setup>
import { ref, computed } from "vue";

// Form data
const form = ref({
  first_name: "",
  last_name: "",
  email: "",
  password: "",
  confirm_password: "",
  day: "",
  month: "",
  year: "",
});

// Trạng thái ẩn/hiện mật khẩu
const showPassword = ref(false);
const showConfirmPassword = ref(false);

// Hàm chuyển đổi trạng thái ẩn/hiện mật khẩu
const togglePasswordVisibility = () => {
  showPassword.value = !showPassword.value;
};
const toggleConfirmPasswordVisibility = () => {
  showConfirmPassword.value = !showConfirmPassword.value;
};

// Tạo danh sách năm (từ năm hiện tại về trước 100 năm)
const currentYear = new Date().getFullYear();
const years = computed(() => {
  const yearsArray = [];
  for (let i = currentYear; i >= currentYear - 100; i--) {
    yearsArray.push(i);
  }
  return yearsArray;
});

// Emit sự kiện submit với dữ liệu form
const emit = defineEmits(["submit"]);
const handleSubmit = () => {
  const date_of_birth = `${form.value.year}-${form.value.month}-${form.value.day}`;
  const userData = {
    first_name: form.value.first_name,
    last_name: form.value.last_name,
    email: form.value.email,
    password: form.value.password,
    confirm_password: form.value.confirm_password, // Thêm confirm_password vào dữ liệu gửi đi
    date_of_birth: date_of_birth,
  };
  emit("submit", userData);
};
</script>

<style lang="scss" scoped>
.form-control,
.form-select {
  border-radius: 6px;
  border: 1px solid #ccd0d5;
  padding: 0.75rem;
  font-size: 1rem;
  color: #1c1e21;
  background-color: #f5f6f7;
  font-weight: 500;
  color: #4a4a4a;
}

.form-control {
  padding-right: 40px;
}

.form-select {
  background-color: #fff;
}

.position-relative {
  position: relative; /* Để định vị con mắt bên trong ô nhập */
}

.eye-icon {
  position: absolute;
  right: 15px;
  top: 50%;
  transform: translateY(-50%);
  cursor: pointer;
  color: #606770;
  font-size: 1rem;
  display: flex;
  align-items: center;
}

.form-label {
  font-size: 1rem;
  color: #606770;
  margin-bottom: 0.45rem;
  text-align: left;
  display: flex;
  padding-left: 5px;
}

.info-icon {
  color: #606770;
  font-size: 1rem;
  margin-left: 0.25rem;
}

.position-relative {
  position: relative; /* Để định vị con mắt bên trong ô nhập */
}

.btn-success {
  background-color: #00a400;
  border: none;
  padding: 0.75rem;
  font-size: 1.0625rem;
  font-weight: 700;
  border-radius: 6px;
  margin-top: 1rem;
}

.btn-success:hover {
  background-color: #008c00;
}
</style>
