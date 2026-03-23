# FPS Game Shooter - Unity 🎯

Proyek sederhana pengembangan game First-Person Shooter (FPS) menggunakan **Unity Engine**. Repository ini berisi script dasar untuk pergerakan pemain, mekanisme menembak, dan logika peluru.

## 📁 Struktur Script
Project ini menggunakan 3 script utama:

* **PlayerMovement.cs**: Mengatur pergerakan karakter (WASD) dan rotasi kamera menggunakan mouse. Menggunakan kombinasi `CharacterController` dan `InputSystem`.
* **PlayerShooting.cs**: Menangani logika *instantiate* peluru (bullet prefab) dan memberikan gaya dorong (*force*) saat menembak.
* **Bullet.cs**: Mengatur umur peluru agar hancur otomatis setelah 3 detik dan mendeteksi tabrakan dengan objek bertag `Enemy`.

## 🚀 Fitur Utama
* **Movement**: Pergerakan berbasis arah kamera (Camera Forward).
* **Mouse Look**: Rotasi pemain yang sinkron dengan gerakan mouse.
* **Shooting System**: Mekanisme tembak dengan *rigidbody force*.
* **Auto-Destruct**: Optimasi memori dengan menghancurkan objek peluru yang sudah tidak terpakai.

## 🛠️ Cara Penggunaan
1. Masukkan script `PlayerMovement` ke objek Player di Unity.
2. Pastikan objek Player memiliki komponen `CharacterController`.
3. Masukkan script `PlayerShooting` ke objek senjata atau Player, lalu tarik prefab peluru ke slot `Bullet Object`.
4. Tambahkan tag **"Enemy"** pada objek lawan agar efek tabrakan peluru berfungsi.

## 💻 Tech Stack
* **Engine**: Unity
* **Language**: C#
* **Input System**: Unity Input System Package
