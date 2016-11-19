using UnityEngine;
using System.Collections.Generic;

public class Tile {


    private List<string> TileStringList = new List<string>(new string[] { "Mountain", "Desert", "Canyon", "Lake", "Swamp", "Volcano", "Cliff", "Ancient Battlefield", "Plateau", "The Ship", "Valley", "Forest", "Teleporter", "Waterfall", "Inlet", "Permanent Storm", "Hidden Bluffs" });

    // Use this for initialization
    public Tile () {
        
    }

    public void Shuffle()
    {
        int n = TileStringList.Count;
        while (n > 1)
        {
            n--;
            int k = (int)(Random.Range(0, TileStringList.Count));
            string value = TileStringList[k];
            TileStringList[k] = TileStringList[n];
            TileStringList[n] = value;
        }
    }
}
