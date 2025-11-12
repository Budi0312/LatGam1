using System;
using NUnit.Framework;
using UnityEngine;

public class SquareMove12 : MonoBehaviour
{
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;
    public bool isMove = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove) //sama dengan if (isMove=true)
        {
            
            if (isMoveRight == true)
            {
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0); //pergerakan ke kanan
            }
            else
            {
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0); //pergerakan ke kiri
            }
        }
        else
        {
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
