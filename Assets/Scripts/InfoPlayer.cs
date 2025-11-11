using UnityEngine;

public class InfoPlayer : MonoBehaviour
{

    [SerializeField]
    Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //Player player = new Player("Fadli", 1, 100);

        //Player player2 = new Player("Em", 2, 200);
        
        
        /*Player player = new Player();
        player.Name = "Fadli";
        player.Level = 1;
        player.Health = 100;

        Player player2 = new Player();
        player2.Name = "Em";
        player2.Level = 2;
        player2.Health = 200;
        */

        Debug.Log(player.Name);
        Debug.Log(player.Level);
        Debug.Log(player.Health);

        /*Debug.Log(player2.Name);
        Debug.Log(player2.Level);
        Debug.Log(player2.Health);
        */


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
