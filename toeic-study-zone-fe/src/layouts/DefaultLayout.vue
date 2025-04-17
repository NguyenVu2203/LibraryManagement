<!-- <template>
  <div class="default-layout">
    <router-view />
  </div>
</template>

<script setup></script>

<style lang="scss" scoped>
.default-layout {
  min-height: 100vh; /* Đảm bảo layout chiếm toàn bộ chiều cao */
  display: flex;
  flex-direction: column;
}
</style> -->
<template>
  <div class="default-layout">
    <NavbarClient />
    <main>
      <router-view />
    </main>
    <FooterClient />
  </div>
</template>

<script setup>
import NavbarClient from "@/components/common/NavbarClient.vue";
import FooterClient from "@/components/common/FooterClient.vue";
</script>

<style lang="scss" scoped>
.default-layout {
  min-height: 100vh;
  display: flex;
  flex-direction: column;

  main {
    flex: 1;
  }
}
</style>
