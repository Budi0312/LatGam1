using System.CodeDom.Compiler;
using UnityEngine;
using UnityEngine.UI;

public class Slideshow : MonoBehaviour
{
    public DBGambar dbGambar;


    public Image objectImage;

    public int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Next ()
    {
        if (index >= dbGambar.ListGambar.Count - 1)
        {
            index = index =0;
        }
         else
        {
            index = index + 1;
        }
        
        objectImage.sprite = dbGambar.ListGambar[index];
    }

    // Update is called once per frame
    public void Previous()
    {
        if (index <= 0)
        {
            index = dbGambar.ListGambar.Count - 1;
        }
        else
        {
            index = index - 1;
        }
        objectImage.sprite = dbGambar.ListGambar[index];
    }
}
