using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StudentRegistrationApp
{
    public partial class MainWindow : Window
    {
        private class Mahasiswa
        {
            public string Nim { get; set; }
            public string Nama { get; set; }
            public string Prodi { get; set; }
            public string JenisKelamin { get; set; }
            public bool Aktif { get; set; }
            public string StatusMakan { get; set; }

            public override string ToString()
            {
                string statusKuliah;

                if (Aktif)
                {
                    statusKuliah = "Aktif";
                }
                else
                {
                    statusKuliah = "Nonaktif";
                }

                return Nim + " | " +
                       Nama + " | " +
                       Prodi + " | " +
                       JenisKelamin + " | " +
                       statusKuliah + " | " +
                       StatusMakan;
            }
        }

        private List<Mahasiswa> dataMahasiswa =
            new List<Mahasiswa>();

        private Mahasiswa mahasiswaDipilih = null;

        public MainWindow()
        {
            InitializeComponent();
            TampilkanData();
            UpdateJumlah();
        }

        private void TampilkanData()
        {
            string kataKunci = txtCari.Text.Trim().ToLower();

            List<Mahasiswa> dataTampil;

            if (string.IsNullOrWhiteSpace(kataKunci))
            {
                dataTampil = dataMahasiswa;
            }
            else
            {
                dataTampil = dataMahasiswa
                    .Where(m =>
                        m.Nim.ToLower().Contains(kataKunci) ||
                        m.Nama.ToLower().Contains(kataKunci))
                    .ToList();
            }

            lstMahasiswa.ItemsSource = null;
            lstMahasiswa.ItemsSource = dataTampil;
        }

        private void UpdateJumlah()
        {
            txtJumlah.Text =
                "Jumlah Mahasiswa: " + dataMahasiswa.Count;
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNim.Text))
            {
                MessageBox.Show("NIM harus diisi!");
                txtNim.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama harus diisi!");
                txtNama.Focus();
                return false;
            }

            if (cmbProdi.SelectedItem == null)
            {
                MessageBox.Show("Pilih program studi!");
                return false;
            }

            if (rbLaki.IsChecked != true &&
                rbPerempuan.IsChecked != true)
            {
                MessageBox.Show("Pilih jenis kelamin!");
                return false;
            }

            if (cmbStatusMakan.SelectedItem == null)
            {
                MessageBox.Show("Pilih status makan!");
                return false;
            }

            return true;
        }

        private void BtnSimpan_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (!ValidasiInput())
            {
                return;
            }

            string nim = txtNim.Text.Trim();

            bool nimSudahAda = dataMahasiswa.Any(m =>
                m.Nim == nim && m != mahasiswaDipilih);

            if (nimSudahAda)
            {
                MessageBox.Show("NIM sudah digunakan!");
                txtNim.Focus();
                return;
            }

            string prodi =
                ((ComboBoxItem)cmbProdi.SelectedItem)
                .Content.ToString();

            string statusMakan =
                ((ComboBoxItem)cmbStatusMakan.SelectedItem)
                .Content.ToString();

            string jenisKelamin;

            if (rbLaki.IsChecked == true)
            {
                jenisKelamin = "Laki-laki";
            }
            else
            {
                jenisKelamin = "Perempuan";
            }

            if (mahasiswaDipilih == null)
            {
                Mahasiswa mahasiswaBaru = new Mahasiswa();

                mahasiswaBaru.Nim = nim;
                mahasiswaBaru.Nama = txtNama.Text.Trim();
                mahasiswaBaru.Prodi = prodi;
                mahasiswaBaru.JenisKelamin = jenisKelamin;
                mahasiswaBaru.Aktif = chkAktif.IsChecked == true;
                mahasiswaBaru.StatusMakan = statusMakan;

                dataMahasiswa.Add(mahasiswaBaru);

                MessageBox.Show("Data mahasiswa berhasil disimpan!");
            }
            else
            {
                mahasiswaDipilih.Nim = nim;
                mahasiswaDipilih.Nama = txtNama.Text.Trim();
                mahasiswaDipilih.Prodi = prodi;
                mahasiswaDipilih.JenisKelamin = jenisKelamin;
                mahasiswaDipilih.Aktif = chkAktif.IsChecked == true;
                mahasiswaDipilih.StatusMakan = statusMakan;

                MessageBox.Show("Data mahasiswa berhasil diubah!");
            }

            TampilkanData();
            UpdateJumlah();
            BersihkanForm();
        }

        private void BtnEdit_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (lstMahasiswa.SelectedItem == null)
            {
                MessageBox.Show("Pilih data yang ingin diedit!");
                return;
            }

            mahasiswaDipilih =
                (Mahasiswa)lstMahasiswa.SelectedItem;

            txtNim.Text = mahasiswaDipilih.Nim;
            txtNama.Text = mahasiswaDipilih.Nama;

            foreach (ComboBoxItem item in cmbProdi.Items)
            {
                if (item.Content.ToString() ==
                    mahasiswaDipilih.Prodi)
                {
                    cmbProdi.SelectedItem = item;
                    break;
                }
            }

            foreach (ComboBoxItem item in cmbStatusMakan.Items)
            {
                if (item.Content.ToString() ==
                    mahasiswaDipilih.StatusMakan)
                {
                    cmbStatusMakan.SelectedItem = item;
                    break;
                }
            }

            if (mahasiswaDipilih.JenisKelamin ==
                "Laki-laki")
            {
                rbLaki.IsChecked = true;
                rbPerempuan.IsChecked = false;
            }
            else
            {
                rbLaki.IsChecked = false;
                rbPerempuan.IsChecked = true;
            }

            chkAktif.IsChecked = mahasiswaDipilih.Aktif;
        }

        private void BtnReset_Click(
            object sender,
            RoutedEventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            txtNim.Clear();
            txtNama.Clear();

            cmbProdi.SelectedIndex = -1;
            cmbStatusMakan.SelectedIndex = -1;

            rbLaki.IsChecked = false;
            rbPerempuan.IsChecked = false;

            chkAktif.IsChecked = true;

            mahasiswaDipilih = null;
            lstMahasiswa.SelectedItem = null;

            txtNim.Focus();
        }

        private void BtnHapus_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (lstMahasiswa.SelectedItem == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            Mahasiswa mahasiswa =
                (Mahasiswa)lstMahasiswa.SelectedItem;

            MessageBoxResult hasil = MessageBox.Show(
                "Hapus data " + mahasiswa.Nim +
                " - " + mahasiswa.Nama + "?",
                "Konfirmasi Hapus",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (hasil == MessageBoxResult.Yes)
            {
                dataMahasiswa.Remove(mahasiswa);

                TampilkanData();
                UpdateJumlah();
                BersihkanForm();

                MessageBox.Show("Data mahasiswa berhasil dihapus!");
            }
        }

        private void TxtCari_TextChanged(
            object sender,
            TextChangedEventArgs e)
        {
            TampilkanData();
        }
    }
}