using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AksiTombol : MonoBehaviour
{
    public Sprite assetGambar; //asset gambar yang akan di masukan
    public Image image; //pastikan using UnityEngine.UI; sudah di masukan, kegunaan Public Image adalah komponen image yang ada di scene

    public TMP_Text objectText; //TMP_Text adalah komponen dari object text yang ada di dalam scene


    public void Aksi() //pastikan public void jika ingin di Listen
    {
        // image.sprite = assetGambar; //Mengubah gambar
        //objectText.text = "Salam Kenal"; //mengubah Text
        //Debug.Log("Klik Tombol");

        SceneManager.LoadScene("DAY3NewScene");
    }

}
