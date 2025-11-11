using System;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    [SerializeField]
    List<Player> ListPlayer = new List<Player>();

       // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
    {
        Player player = ListPlayer.Find(element => element.Level > 15);
        Debug.Log(player.Name);

        //bool isExsist = ListPlayer.Exsist(element => element == "Fadhli");
        //Debug.Log(isExsist);
        //ListPlayer.Insert(1, "Anton");
        //ListPlayer.RemoveAt(0);
    }

   
}
