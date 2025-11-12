using UnityEngine;

public class KotakWarna : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //_spriteRenderer = GetComponent<SpriteRenderer>();
        //_spriteRenderer.color = Color.cyan;

        
        //jika ingin warna menggunakan Syntax HTML
        _spriteRenderer = GetComponent<SpriteRenderer>(); 
        Color warna; //deklarasi warna

        ColorUtility.TryParseHtmlString("#bdef7bff", out warna);
        _spriteRenderer.color = warna; //memasukan informasi warna
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
