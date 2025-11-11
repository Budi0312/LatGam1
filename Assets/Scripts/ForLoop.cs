using UnityEngine;

public class ForLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 5;
        int hasil = 1;

        for (int i = 1; i <= n; i++)
        {
            hasil *= i; // hasil = hasil * i
        }

        Debug.Log("Faktorial dari " + n + " adalah " + hasil);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
