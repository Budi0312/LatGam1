// Mengimpor library yang diperlukan
using TMPro;                    // Untuk komponen TextMeshPro (teks modern di Unity)
using UnityEngine;              // Library utama Unity untuk GameObject, MonoBehaviour, Transform, dll
using UnityEngine.SceneManagement; // Untuk fungsi pengelolaan scene (LoadScene, dsb)
using UnityEngine.UI;           // Untuk mengakses komponen UI seperti Image dan Button

// Kelas utama untuk mengatur aksi tombol di UI
public class AksiTombol : MonoBehaviour
{
    // Menyimpan sprite (gambar) yang akan dimasukkan ke komponen Image saat tombol ditekan
    public Sprite assetGambar; //asset gambar yang akan di masukan

    // Komponen Image yang ada di Scene, tempat gambar (sprite) akan ditampilkan atau diubah
    public Image image; //pastikan using UnityEngine.UI; sudah di masukan, kegunaan Public Image adalah komponen image yang ada di scene

    // Komponen TextMeshPro di Scene, tempat teks dapat diubah lewat script
    public TMP_Text objectText; //TMP_Text adalah komponen dari object text yang ada di dalam scene


    public void Aksi() //pastikan public void jika ingin di Listen
    {
        // image.sprite = assetGambar; //Mengubah gambar
        //objectText.text = "Salam Kenal"; //mengubah Text
        //Debug.Log("Klik Tombol");

        
        
        
        // 👉 Memuat (load) scene baru dengan nama "DAY3NewScene"
        // Pastikan nama scene ini sama persis dengan nama scene yang ada di folder "Assets/Scenes"
        // dan sudah ditambahkan ke Build Settings (File → Build Settings → Scenes In Build)
        SceneManager.LoadScene("DAY3NewScene");
    }

}
