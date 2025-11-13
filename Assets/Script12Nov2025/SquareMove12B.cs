using UnityEngine;

public class SquareMove12B : MonoBehaviour     // Variabel dan fungsi akan didefinisikan di dalam class ini

{

    //deklarasi referensi GameObject dengan tipe data clas InteraksiTombol
    //ini juga digunakan untuk script ini bisa berkomunikasi dengan gameObject yang memiiki class InteraksiTombol
    public InteraksiTombol interaksiTombol;

    //deklarasi referensi GameObject dengan tipe data clas arahGerak sesuai dengan emunelatornya
    public ArahGerak arahGerak = ArahGerak.kanan;
    
    //deklarasi referensi GameObject dengan tipe data clas InteraksiTombol
    public float kecepatan = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerak)  // Struktur switch digunakan untuk memilih tindakan berdasarkan nilai dari variabel 'arahGerak'
        {
            // Menggerakkan objek ke arah Y positif (naik)
            // kecepatan * Time.deltaTime = jarak yang konsisten setiap detik, tidak tergantung FPS
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0); //eksekusi kalau ke atas
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0); //eksekusi kalau ke bawah
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0); //eksekusi kalau keatas
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0); //eksekusi kalau keatas
                break;
        }
    }
    void OnCollisionEnter2D(Collision2D collision) //OnCOllision fungsi akan aktif jika ada objek bertabrakan
    {
        if (collision.gameObject.CompareTag("Wall")) //meriksa apakah objek yang di tabrak memiliki Tag "WALL"
        {
            Debug.Log("Tabark Dinging");    //menampilkan pesan di Console Dinding
            if (arahGerak == ArahGerak.atas) //meriksa arah gerak saat ini, kemudian membalikan arah gerak jika menabrak dinding
            {
                //jika arah gerak ke atas, dan di ubah menjadi kebawah
                arahGerak = ArahGerak.bawah;
            }
            else if (arahGerak == ArahGerak.bawah)
            {
                //jika arah gerak ke bawah, dan di ubah menjadi ke atas               
                arahGerak = ArahGerak.atas;
            }
            else if (arahGerak == ArahGerak.kiri)
            {
                //jika arah gerak ke kiri, dan di ubah menjadi ke kanan
                arahGerak = ArahGerak.kanan;
            }
            else
            {
                //jika arah gerak ke kanan, dan di ubah menjadi ke kiri
                arahGerak = ArahGerak.kiri;
            }
            interaksiTombol.skor++; //menambahkan nilai skor tiap objek memantul dari Dinding
            TambahSkor();   //memanggil fungsi TambahSkor() untuk memperbaharui tampilan skor di UI
        }

    }
    
    
    public void TambahSkor()    //berfungsi menampilkan atau memperbaharui skor pada UI
    {
        //mengakses kompoken teks dari UI melalui variabel "interaksiTombol"
        //kemudian menampikan teks "Skor :" diikuti dengan nilai yang di konversi menjadi string
        interaksiTombol.TeksSkor.text = "Skor :" + interaksiTombol.skor.ToString();
    }

}

//pendeklarasian sebuah emulator dengan nama ArahGerak
//emulator di gunakan untuk membuat daftar nilai tetap (konstan) yang merepresentasikan arah gerak
public enum ArahGerak
{
    diam, //objek tidak bergerak
    atas,//objek gerak ke atas
    bawah,//objek gerak ke bawah
    kiri,//objek gerak ke kiri
    kanan,//objek gerak ke kanan

}