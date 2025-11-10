using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Contoh3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(kali(2, 7, 2));  //Tentang FUNTION

    }
    
    public int kali (int angka1, int angka2, int angka3) //Tentang FUNTION
    {
        int result = angka1 * angka2 * angka3; //Tentang FUNTION
        return result; //Tentang FUNTION
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
