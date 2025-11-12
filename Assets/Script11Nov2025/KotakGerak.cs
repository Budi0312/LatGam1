using UnityEngine;
using UnityEngine.Rendering;

public class KotakGerak : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    public bool isMoveRight = true;
   
   // Update is called once per frame
    void Update()
    {
        if (isMoveRight)
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0); //localScale untuk Transform mengerakan objek
        }
        else
        {
           gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0); //localScale untuk Transform mengerakan objek

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Tabrakan Objek");
        if (isMoveRight)
        {
            isMoveRight = false;
            
        }
        else
        {
            isMoveRight = true;
        }
    }
}
