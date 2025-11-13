using UnityEngine;

public class CircleMove : MonoBehaviour
{
    public InteraksiTombol interaksiTombol;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interaksiTombol.nyawa=50;
        KurangNyawa();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Kotak"))
        {
           Debug.Log("Menabrak Kotak");
            interaksiTombol.nyawa--;
            KurangNyawa(); 
        
        }
        
         
    }
        
    public void KurangNyawa()
    {
        interaksiTombol.KurangNyawa.text = "Nyawa :" + interaksiTombol.nyawa.ToString();
    }
        
    
}
