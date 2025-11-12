using System;
using UnityEngine;
using UnityEngine.Events;

public class DeteksiInput : MonoBehaviour
{
    public UnityEvent inputEvent;
    //public Action inputEvent; //jika ingin menambahkan inputEvent harus ada using System;

    //public Score objectScore;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //objectScore.AddScore(); untuk tambah score
            inputEvent?.Invoke(); //untuk memanggil dan input score, dan akan mendeteksi pertanyaan dan tidak akan terjadi eror jika di tambah tanda tanya (?)
        }
    }
}
