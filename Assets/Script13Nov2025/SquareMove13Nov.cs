using UnityEngine;

public class SquareMove13Nov : MonoBehaviour
{
    //boolean untuk kontrol arah gerak 
    public bool isMoveRight = true;

    //float untuk kecepatan
    public float kecepatan = 5.0f;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //digunakan kontrol boolean dan buat gerak
         if (isMoveRight == true)
            {
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0); //pergerakan ke kanan
            }
        else
            {
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0); //pergerakan ke kiri
            }
    }
}
