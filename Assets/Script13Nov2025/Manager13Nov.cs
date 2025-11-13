using UnityEngine;
using TMPro; //untuk memasukan TMP_Text

public class Manager13Nov : MonoBehaviour
{
    public PemainLompat pemainLompat; //untuk memanggil dari syntax PemainLombat.cs
    public int skor;
    public TMP_Text teksskore;

    public SquareMove13Nov squareMove13Nov; //penamaan variabel sesuai dengna nama dari syntaxnya

    public GameObject bolaJatuh; //variabel untuk referensi prefab bola yang akan jatuh

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //teksskore.text="0"; jika menggunakan ini bisa, cuma tidak mengikuti public int skor
        UpdateTeksSkor(); //code untuk mengikuti hasil dari public int skor
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Klik Kiri");
            //Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("Posisi Mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            //ToggleKiriKanan(); dimasukan kepada klik kiri/kanan untuk pemanggilan menggunakan klik Kiri/kanan, jika ingin satu persatu
            squareMove13Nov.isMoveRight=false;
            MunculDariAtas(); //Fungtion harus di panggil sesuai dengan penamaan di awal void MunculDariAtas ()
            pemainLompat.Lompat(); //untuk tiap Referensi ini seperti Referensi Lompat, harus d buat Public dahulu untuk Referensinya

        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik Kanan");
            //Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("Posisi Mouse ada di " + vector.ToString());
            KurangSkor();
            UpdateTeksSkor();
            squareMove13Nov.isMoveRight=true;

        }
    }

    void TambahSkor()
    {
        skor++; //tambah skor
        Debug.Log("Integer Skor Tambah");
    }

    void KurangSkor()
    {
        skor--; //kurang skor
        Debug.Log("Integer Skor Kurang");
    }

    void UpdateTeksSkor()
    {
        teksskore.text=skor.ToString(); //mengubah nilai mengikuti integer
        Debug.Log("Ubah Skor");
    }
    
    void ToggleKiriKanan() 
    {
        if (squareMove13Nov.isMoveRight)
        {
            squareMove13Nov.isMoveRight=false;
        }
        else
        {
            squareMove13Nov.isMoveRight=true;
        }
    }

    void MunculDariAtas() 
    {
        Vector3 posisiKlik=Camera.main.ScreenToWorldPoint(Input.mousePosition); //ambil posisi dimana posisi kursor berada
        Vector3 titikAtas=Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height,0)); //ambil posisi titik paling atas layar
        Vector3 tempatJatuh=new Vector3(posisiKlik.x, titikAtas.y,0);   //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar untuk Vector3 bernama tempatJatuh

        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);   //memunculkan game object dengan nama bolaJatuh diposisi tempatJatuh dan dengan rotasi Quaternion.identity
    }

}
