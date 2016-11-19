using UnityEngine;
using System.Collections.Generic;

public class DisasterDeck {


    private List<string> DisasterStringList = new List<string>(new string[] {"Sudden Spoiling", "Suit Leak", "Acid Rain", "Inventory Loss", "Artifact Lost", "Ship Ravaged", "Inventory Loss", "Tragic Failure", "Lose Hope", "Completely Lost", "Catastrophic Failure", "Bad Salvage", "Misplaced Resources", "Catastrophic Failure", "Bad Salvage" });


    // Use this for initialization
    public DisasterDeck () {
        
    }

    public void Shuffle ()
    {
        int n = DisasterStringList.Count;
        while (n > 1)
        {
            n--;
            int k = (int)(Random.Range(0, DisasterStringList.Count));
            string value = DisasterStringList[k];
            DisasterStringList[k] = DisasterStringList[n];
            DisasterStringList[n] = value;
        }
    }

}
