using UnityEngine;
using System.Collections;

public class DiscoveryCard {

    string cardName;
    int food = 0;
    int oxygen = 0;
    int scrap = 0;

	// Use this for initialization
	void Start (string newCard) {
        cardName = newCard;
        switch (newCard)
        {
            case ("cat"):
                food = 0;
                oxygen = 0;
                scrap = 0;
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
