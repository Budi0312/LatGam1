using System.Collections.Generic;
using System.Globalization;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public SquareMove12 squareMove12;
    public TMP_Text KataBerubah; //variabel KataBerubah
    public TMP_Text NamaBerubah; //variabel NamaBerubah
    public List<string> daftarNama; //variabel DaftarNama
    public int idNama = 0; //Variabel Nama

    public GameObject SquareUbahWarna;

     private bool isAutoRandom = false;   // penanda mode random otomatis untuk warna
    public float speedRandom = 0.5f;     // kecepatan perubahan warna (detik)


    void Start()
    {
        NamaBerubah.text = daftarNama[idNama];
    }

    public void LanjutNama()
    {
        if (idNama < daftarNama.Count - 1)
        {
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        NamaBerubah.text = daftarNama[idNama];

    }

    public void KembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        NamaBerubah.text = daftarNama[idNama];

    }


    public void UbahKataKiri()
    {
        string kata = "Kiri";
        KataBerubah.text = kata;
    }

    public void UbahKataKanan()
    {
        string kata = "Kanan";
        KataBerubah.text = kata;
    }


    
    //buatkan 4 Fungction Warna
    public void UbahWarna(Color warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }

    public void UbahWarnaMerah()
    {
        UbahWarna(Color.red);
    }
    public void UbahWarnaBiru()
    {
        UbahWarna(Color.blue);

    }
    public void UbahWarnaHijau()
    {
        UbahWarna(Color.green);

    }
    /*public void UbahWarnaAcak()
    {
        Color col = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        UbahWarna(col);
    }*/
    
    // 🔹 Fungsi acak otomatis
    public void UbahWarnaAcak()
    {
        isAutoRandom = !isAutoRandom; // toggle ON/OFF
        if (isAutoRandom)
        {
            InvokeRepeating(nameof(RandomWarnaLoop), 0f, speedRandom);
        }
        else
        {
            CancelInvoke(nameof(RandomWarnaLoop));
        }
    }

    void RandomWarnaLoop()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        UbahWarna(col);
    }

    public void Mulai()
    {
        squareMove12.isMove = true;
    }
    public void Berhenti()
    {
        squareMove12.isMove = false;
    }
    public void GerakKanan()
    {
        squareMove12.isMoveRight = true;
    }
     public void GerakKiri()
    {
        squareMove12.isMoveRight = false;

    }
}
