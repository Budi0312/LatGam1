using UnityEngine;

[System.Serializable]
public class Player
{

    public string Name;
    public int Level;
    public int Health;

    //tentang CONSTRUKTUR
    public Player(string name, int level, int heath)
    {
        Name = name;
        Level = level;
        Health = heath;
    }
}
