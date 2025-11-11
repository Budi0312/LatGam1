using UnityEngine;

public class FactorialCalculator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //Tentang Faktorial dengan Perkalian kedepan
        int faktorial = 4;
        int hasil = 1;
        for (int i = 1; i <= faktorial; i++)
        {
            hasil = hasil * i;
        }
        Debug.Log(hasil);
        
        //hasil dari sintak diatas 
        //hasil = 1, i=1, hasil = 1*1
        //hasil = 1, i=2, hasil = 1*2
        //hasil = 2, i=3, hasil = 2*3
        //hasil = 6, i=4, hasil = 6*4 = 24
        

        
         /*//Tentang Faktorial dengan Perkalian mundur
        int faktorial = 4;
        int hasil = 1;
        for (int i = faktorial; i > 0; i--)
        {
            hasil = hasil *i;
        }
        Debug.Log(hasil);*/
        
        //hasil dari sintak diatas 
        //hasil = 1, i=4, hasil = 1*4=4
        //hasil = 4, i=3, hasil = 4*3=12
        //hasil = 12, i=2, hasil = 12*2 =24
        //hasil = 24, i=1, hasil = 24*1 = 24
        




        /*Tentang FAKTORIAL
        int n = 4;
        int result = 1;
        string process = n + "! = ";

        
        for (int i = n; i >= 1; i--)
        {
            result *= i;
            process += i;

            if (i > 1)
                process += " x ";
        }

        process += " = " + result;

        Debug.Log(process); */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
