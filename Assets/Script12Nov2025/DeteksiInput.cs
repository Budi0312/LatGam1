using System;
using UnityEngine;

public class DeteksiInput : MonoBehaviour
{
    public Action inputEvent; //jika ingin menambahkan inputEvent harus ada using System;

    public Score objectScore;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //objectScore.AddScore(); untuk tambah score
            inputEvent.Invoke(); //untuk memanggil dan input score
        }
    }
}
