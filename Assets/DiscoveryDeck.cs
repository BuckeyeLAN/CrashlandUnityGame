using UnityEngine;
using System.Collections.Generic;

public class DiscoveryDeck {

    private List<string> DiscoveryStringList = new List<string>(new string[] { "Controller", "Repurposer", "Meager Synthesis", "Lucky Find", "Forge", "Underwater Scavenge", "Search Wreckage", "Oxygen Synthesis", "Perishable Food", "Drastic Discovery", "Oxygen Tanks", "Fortuneate Find", "Redezvous", "Distress Call", "Unstable Teleporter", "Matter Reorganizer", "Oxygen Synthesizer", "Hidden Cache", "Power Cell", "Reconstructor", "Valuable Find", "Fateful Find", "Salvage", "False Hope" });

    // Use this for initialization
    public DiscoveryDeck () {
        
    }

    public void Shuffle()
    {
        int n = DiscoveryStringList.Count;
        while (n > 1)
        {
            n--;
            int k = (int)(Random.Range(0, DiscoveryStringList.Count));
            string value = DiscoveryStringList[k];
            DiscoveryStringList[k] = DiscoveryStringList[n];
            DiscoveryStringList[n] = value;
        }
    }
}
