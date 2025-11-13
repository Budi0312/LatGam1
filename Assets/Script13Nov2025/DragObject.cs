using UnityEngine;

public class DragObject : MonoBehaviour
{
    
    void OnMouseDrag()
    {
        Vector2 worldMousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 squarePosition = new Vector2(worldMousePosition.x,transform.position.y);
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,0));
        squarePosition.x=Mathf.Clamp(squarePosition.x, minimum.x,maximum.x);
        //squarePosition.x=Mathf.Clamp(squarePosition.x, minimum.x,maximum.x);
        //squarePosition.x=Mathf.Clamp(squarePosition.x, -8.,8); //Mathf.Clamp untuk membatasi gerak dari objek di layar game kiri dan kanan
        transform.position=squarePosition; //squarePosition untuk mengendalikan di sumbu X, sedangkan jika menggunakan worldMousePosition akan bisa di kendalikan segala posisi
    }
    
    
    /*void OnMouseDown()
    {
     Debug.Log("Down");   
    }
    void OnMouseEnter()
    {
        Debug.Log("Enter");
    }

    void OnMouseExit()
    {
        Debug.Log("Exit");
    }
    */

}
