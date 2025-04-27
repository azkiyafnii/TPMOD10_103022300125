namespace MOD10_103022300125
{
    public class Mahasiswa // Mendeklarasikan kelas Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        // Konstruktor untuk menginisialisasi objek Mahasiswa dengan nama dan NIM
        public Mahasiswa(string nama, string nim)
        {
            Nama = nama; 
            Nim = nim;  
        }
    }
}
