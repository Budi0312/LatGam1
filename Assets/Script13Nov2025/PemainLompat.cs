using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    public float forceMultiplayer =3.0f; //public float forceMultiplayer =3.0f; variabel untuk perhitungan daya lombat

    public bool diLantai =false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Lompat() //referensi harus penggunakan Public supaya bisa di panggil oleh semuanya
    {
        if (diLantai)
        {
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up*forceMultiplayer, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("lagi Lompat");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Lantai"))
        {
            diLantai=true;
            Debug.Log("di lantai");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Lantai"))
        {
            diLantai=false;
            Debug.Log("di udara");
        }
    }
}
