using System.Collections;
using UnityEngine;

public class PenghapusObject : MonoBehaviour //MonoBehaviour akan menghapus dari gameObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,5);
        //StartCoroutine(HapusObject()); jika menggunakan IEnumerator
    }

   /* digunakan berbarengan dengan StartCoroutine(HapusObject());
   IEnumerator HapusObject()
    {
        yield return new WaitForSeconds(3); //untuk menghapus dalam 2 detik setelah objek muncul
        Destroy(gameObject); 
    }
    */
}
