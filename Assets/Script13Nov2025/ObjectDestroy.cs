using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 posisiKlik= Camera.main.ScreenToWorldPoint(Input.mousePosition); //unutk mendapatkan posisi mouse dengan ScreenToWorldPoint dan mousePosition
            Collider2D objectTerdeteksi = Physics2D.OverlapPoint(posisiKlik);//OverlapPoint(); akan mendeteksi pada satu titik apakah ada objek atau tidak
            if (objectTerdeteksi != null)
            {
                Destroy(objectTerdeteksi.gameObject);//objectTerdeteksi ini ialah Collidernya bukan Objeknya, jadi yang di hapus bukan Collidernya melainkan GameObjectnya
            }
        }
    }
}
