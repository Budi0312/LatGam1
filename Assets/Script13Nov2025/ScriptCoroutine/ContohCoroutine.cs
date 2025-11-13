using System.Collections;
using UnityEngine;

public class ContohCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CobaCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //buatkan function IEnumerator untuk menggunakan Coroutine
    //Tipe pengembalian (return type) khusus untuk fungsi Coroutine di Unity
    //Nama dari fungsi Coroutine. Kamu bisa menjalankannya dengan StartCoroutine(CobaCoroutine());
    IEnumerator CobaCoroutine()
    {
        Debug.Log("Perintah 1");

        //Instruksi untuk menunda eksekusi kode berikutnya dalam coroutine untuk sementara waktu
        //Menunda kelanjutan coroutine selama 5 detik waktu game (bukan waktu real di komputer).
        yield return new WaitForSeconds(5); 

        Debug.Log("Perintah 2");   
    }

}
