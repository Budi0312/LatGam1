using System;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField]
    Player[] ArrayPlayer;

    //public string[] ArrayNama = { "Asep", "Tono", "Budi" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
    {
        /*Debug.Log(ArrayNama[1]); //menampilkan array dengan indeks 1 yaitu Tono

        ArrayNama[0] = "Fadhli"; //mengganti nilai array indeks ke 0 menjadi Fadhli
        Debug.Log(ArrayNama[0]);
        */

        for (int index = 0; index < ArrayPlayer.Length; index++)
        {
            Debug.Log(ArrayPlayer[index].Name);
        }

        foreach (Player player in ArrayPlayer)
        {
            Debug.Log(player.Name);
        }

        Debug.Log(ArrayPlayer.Length); //Menampilkan panjang array

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
