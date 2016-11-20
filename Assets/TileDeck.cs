using UnityEngine;
using System.Collections.Generic;

public class TileDeck {

    private List<Tile> Deck;

    // Use this for initialization
    public TileDeck () {

        addTileTypeToDeck(new Mountain());
        addTileTypeToDeck(new Desert());
        addTileTypeToDeck(new Canyon());
        addTileTypeToDeck(new Lake());
        addTileTypeToDeck(new Swamp());
        addTileTypeToDeck(new Volcano());
        addTileTypeToDeck(new Cliff());
        addTileTypeToDeck(new AncientBattlefield());
        addTileTypeToDeck(new Plateau());
        addTileTypeToDeck(new Valley());
        addTileTypeToDeck(new Forest());
        addTileTypeToDeck(new Teleporter());
        addTileTypeToDeck(new Waterfall());
        addTileTypeToDeck(new Inlet());
        addTileTypeToDeck(new PermanentStorm());
        addTileTypeToDeck(new HiddenBluffs());

    }

    public void Shuffle()
    {
        int n = Deck.Count;
        while (n > 1)
        {
            n--;
            int k = (int)(Random.Range(0, Deck.Count));
            Tile value = Deck[k];
            Deck[k] = Deck[n];
            Deck[n] = value;
        }
    }

    public GameObject Draw()
    {
        Tile tileToMake = Deck[0];
        GameObject tile = new GameObject();
        
        

        Deck.RemoveAt(0);
        return tile;
    }

    private void addTileTypeToDeck(Tile input)
    {
        Deck.Add(input);
        for (int x = 0; x < input.count - 1; x++)
            Deck.Add(input.copy());
    }
}
