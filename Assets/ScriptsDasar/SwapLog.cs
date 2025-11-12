using UnityEngine;

public class Contoh : MonoBehaviour
{
    int Number1 = 10;
    int Number2 = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {     
        // Proses swap (penukaran nilai)
        int Number3 = Number1;  //Number1 = 10, Number2 = 7, Number3 = 10
        Number1 = Number2;  //Number1 = 10, Number2 = 7, Number3 = 10
        Number2 = Number3;  //Number1 = 7, Number2 = 10, Number3 = 10

        //pertukaran setelah swap
        Debug.Log("Setelah swap:");
        Debug.Log("Number1 = " + Number1);
        Debug.Log("Number2 = " + Number2);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("hello Kawan"); //LOG untuk menunjukan/menampilkan pesan pada window consol pada Unity
    }
}
