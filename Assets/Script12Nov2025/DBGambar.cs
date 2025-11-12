using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DBGambar", menuName = "DatabaseGambar/ListGambar")]
public class DBGambar : ScriptableObject
{
    public List<Sprite> ListGambar = new List<Sprite>();
}
