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

![Tampilan Form Registrasi](<img width="1170" height="802" alt="Screenshot 2026-09-30 205602" src="https://github.com/user-attachments/assets/93bdaecf-cd7d-4f4a-938a-3d2fc35239af" />)

---

### 2. Tambah Data Mahasiswa

Fitur **Simpan** digunakan untuk menambahkan data mahasiswa ke dalam ListBox.

Data yang dimasukkan akan ditampilkan dengan format berikut:

```text
NIM | Nama | Program Studi | Jenis Kelamin | Status | Status Makan
```

Contoh data:

```text
20260001 | Budi Santoso | Teknik Informatika | Laki-laki | Aktif | Sudah Makan
```

![Tambah Data Mahasiswa](screenshots/02-tambah-data.png)

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

Jika input belum lengkap, aplikasi menampilkan pesan peringatan menggunakan `MessageBox`.

![Validasi Input](screenshots/03-validasi.png)

---

### 4. Pencarian Data Mahasiswa

Fitur pencarian digunakan untuk mencari mahasiswa berdasarkan NIM atau nama mahasiswa.

Pencarian dilakukan secara langsung saat pengguna mengetik kata kunci pada TextBox pencarian.

Contoh:

```text
Kata kunci: Budi
```

Aplikasi hanya menampilkan data mahasiswa yang namanya mengandung kata `Budi`.

![Pencarian Data Mahasiswa](screenshots/04-pencarian.png)

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

Langkah penggunaan:

1. Pilih salah satu data mahasiswa pada ListBox.
2. Klik tombol **Hapus**.
3. Pilih **Yes** pada dialog konfirmasi.
4. Data mahasiswa akan dihapus dari daftar.

![Hapus Data Mahasiswa](screenshots/06-hapus-data.png)

---

### 7. Reset Form

Fitur **Reset** digunakan untuk mengosongkan seluruh form input.

Data yang akan dikosongkan:

- NIM
- Nama mahasiswa
- Program studi
- Jenis kelamin
- Status makan
- Pilihan data pada ListBox

Status mahasiswa aktif akan dikembalikan ke kondisi tercentang.

![Reset Form](screenshots/07-reset-form.png)

---

### 8. Counter Jumlah Mahasiswa

Aplikasi menampilkan jumlah total mahasiswa yang tersimpan pada bagian bawah daftar data.

Counter akan bertambah saat data mahasiswa berhasil ditambahkan dan akan berkurang saat data mahasiswa dihapus.

Contoh:

```text
Jumlah Mahasiswa: 3
```

![Counter Jumlah Mahasiswa](screenshots/08-counter-mahasiswa.png)

---
