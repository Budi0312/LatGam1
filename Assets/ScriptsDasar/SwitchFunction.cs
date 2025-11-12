using NUnit.Framework;
using UnityEngine;

public class Contoh2 : MonoBehaviour
{
   int nyawa = 10; //Tentang FUNTION
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MinumObat(); //Tentang FUNTION
        MinumObat(); //Tentang FUNTION
        Debug.Log(nyawa); //Tentang FUNTION


        /*Tentang SWITCH
        int nomor = 3;
        string weaponName;

        switch (nomor)
        {
            case 1:
                Debug.Log ("Basic Sword");
                break;
            case 2:
                Debug.Log  ("Electric Bow");
                break;
            case 3:
                Debug.Log  ("Fire Spell");
                break;
            default:
                Debug.Log ("Unknown Weapon");
                break;
        }*/

        /*tentang IF ELSE 
        int age = 17;
        int money = 50000;

        if (age >= 18 || money >=100000)
        {
            Debug.Log("Umur kamu " + age + " tahun. Maaf, kamu belum boleh masuk bioskop.");
        }
        else
        {
            Debug.Log("Umur kamu " + age + " tahun. Silakan masuk, selamat menonton!");
        }*/

    }

    //Tentang FUNTION
    public void MinumObat()
    {
        Debug.Log("pemain minum obat");
        Sembuhkan(30);
    }
    
    //Tentang FUNTION
    public void Sembuhkan (int tambahkanNyawa)
    {
        nyawa = nyawa + tambahkanNyawa;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
