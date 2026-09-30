# Student Registration App

## Identitas Mahasiswa

| Keterangan | Isi |
|---|---|
| Nama | Al Jad Kaukabudduri Hardianto |
| NRP | 5025241248 |
| Kelas | PBKK C |

---

## Deskripsi Aplikasi

**Student Registration App** adalah aplikasi desktop sederhana berbasis **WPF** dan **C#** untuk melakukan pendataan mahasiswa.

Aplikasi ini digunakan untuk memasukkan, menampilkan, mencari, mengubah, dan menghapus data mahasiswa. Data mahasiswa yang dikelola meliputi:

- NIM
- Nama mahasiswa
- Program studi
- Jenis kelamin
- Status mahasiswa aktif atau nonaktif
- Status sudah makan atau belum

---

## Fitur Aplikasi

### 1. Tampilan Form Registrasi Mahasiswa

Halaman utama menyediakan form untuk memasukkan data mahasiswa. Form terdiri dari input NIM, nama mahasiswa, program studi, jenis kelamin, status aktif, dan status makan.

<img width="1170" height="802" alt="Screenshot 2026-09-30 205602" src="https://github.com/user-attachments/assets/93bdaecf-cd7d-4f4a-938a-3d2fc35239af" />

---

### 2. Tambah Data Mahasiswa

Fitur **Simpan** digunakan untuk menambahkan data mahasiswa ke dalam ListBox.

Data yang dimasukkan akan ditampilkan dengan format berikut:

```text
NIM | Nama | Program Studi | Jenis Kelamin | Status | Status Makan
```

Contoh data:

```text
5025241248 | Al Jad Kaukaudduri Hardianto | Teknik Informatika | Laki-laki | Aktif | Sudah Makan
```

<img width="1166" height="801" alt="Screenshot 2026-09-30 205802" src="https://github.com/user-attachments/assets/a6a8eaf5-ae53-4786-8e76-007e4ae072b7" />

---

### 3. Validasi Input

Sebelum data disimpan, aplikasi memeriksa apakah seluruh input wajib sudah diisi.

Validasi yang tersedia:

- NIM tidak boleh kosong.
- Nama mahasiswa tidak boleh kosong.
- Program studi harus dipilih.
- Jenis kelamin harus dipilih.
- Status makan harus dipilih.
- NIM tidak boleh sama atau duplikat.

<img width="1170" height="801" alt="Screenshot 2026-09-30 205640" src="https://github.com/user-attachments/assets/129f421c-1906-486a-809c-96559e14ab54" />

---

### 4. Pencarian Data Mahasiswa

Fitur pencarian digunakan untuk mencari mahasiswa berdasarkan NIM atau nama mahasiswa.

Pencarian dilakukan secara langsung saat pengguna mengetik kata kunci pada TextBox pencarian.

Contoh:

```text
Kata kunci: Le
```

Aplikasi hanya menampilkan data mahasiswa yang namanya mengandung kata `Le`.

<img width="1171" height="803" alt="Screenshot 2026-09-30 205816" src="https://github.com/user-attachments/assets/0b4cd50c-080e-4820-81f2-5646bcc50c28" />

---

### 5. Edit Data Mahasiswa

Fitur **Edit** digunakan untuk memperbarui data mahasiswa yang sudah tersimpan.

Langkah penggunaan:

1. Pilih data mahasiswa pada ListBox.
2. Klik tombol **Edit**.
3. Data mahasiswa akan muncul kembali pada form input.
4. Ubah data yang diperlukan.
5. Klik tombol **Simpan** untuk menyimpan perubahan.

![Edit Data Mahasiswa](screenshots/05-edit-data.png)

---

### 6. Hapus Data Mahasiswa

Fitur **Hapus** digunakan untuk menghapus data mahasiswa yang dipilih dari ListBox.

Sebelum data dihapus, aplikasi menampilkan konfirmasi agar data tidak terhapus secara tidak sengaja.

<img width="1172" height="807" alt="Screenshot 2026-09-30 205828" src="https://github.com/user-attachments/assets/47e6575b-075d-4dd8-a826-2620d1bb89cb" />

---
