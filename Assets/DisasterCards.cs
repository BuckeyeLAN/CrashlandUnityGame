using UnityEngine;
using System.Collections;

public class DisasterCard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    abstract public class Disaster
    {
        abstract public int count { get; set; }
        abstract public string description { get; set; }
        abstract public int oxygen_loss { get; set; }
        abstract public int food_loss { get; set; }
        abstract public int scrap_loss { get; set; }
    }
    public class Sudden_Spoiling : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 2 food"; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 2; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
    public class Suit_Leak : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 1 )2"; } set { } }
        public override int oxygen_loss { get { return 1; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
    public class Acid_Rain : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 2 scrap"; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 2; } set { } }
    }
    public class Inventory_Loss : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 1 food, 1 O2, and 1 scrap"; } set { } }
        public override int oxygen_loss { get { return 1; } set { } }
        public override int food_loss { get { return 1; } set { } }
        public override int scrap_loss { get { return 1; } set { } }
    }
    public class Artifact_Lost : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard an item in your inventory"; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
    public class Ship_Ravaged : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard the ship inventory"; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
    public class Tragic_Failure : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 2 food and discard 1 scrap"; } set { } }
        public override int oxygen_loss { get { return 2; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 1; } set { } }
    }
    public class Lose_Hope : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 1 scrap and shuffle the discovery discard pile into the discovery pile."; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 1; } set { } }
    }
    public class Completely_Lost : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Move to the ship."; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
    public class Catastrophic_Failure : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard a part in your inventory."; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
    public class Bad_Salvage : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 1 scrap"; } set { } }
        public override int oxygen_loss { get { return 0; } set { } }
        public override int food_loss { get { return 0; } set { } }
        public override int scrap_loss { get { return 1; } set { } }
    }
    public class Misplaced_Resources : Disaster
    {
        public override int count { get { return 2; } set { } }
        public override string description { get { return "Discard 1 food and 1 O2"; } set { } }
        public override int oxygen_loss { get { return 1; } set { } }
        public override int food_loss { get { return 1; } set { } }
        public override int scrap_loss { get { return 0; } set { } }
    }
}
