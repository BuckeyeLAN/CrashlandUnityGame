abstract public class DiscoveryCards
{
    abstract public int count { get; set; }
    abstract public string description { get; set; }
    abstract public bool choice { get; set; }
    abstract public string partType { get; set; }
    abstract public string itemType { get; set; }
    abstract public int getDiscovery { get; set; }
    abstract public int incurDisaster { get; set; }
    abstract public int food_change { get; set; }
    abstract public int scrap_change { get; set; }
    abstract public int oxygen_change { get; set; }

}

public class Controller : DiscoveryCards
{
    public override int count { get { return 6; } set { } }
    public override string description { get { return ""; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Repurposer : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Use to discover a card of your choice in the discovery discard pile and incur 1 disaster."; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Repurposer"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 1; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Forge : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "You may discard an item to add 2 scrap"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Forge"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Meager_Synthesis : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 1 O2"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 1; } set { } }

}
public class Lucky_Find : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 1 food and 1 O2 OR Add 2 food and 2 O2 and incur 1 disaster"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Underwater_Scavenge : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 1 food OR Add 3 food and incur 1 disaster"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Oxygen_Synthesis : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 2 O2 OR Add 6 O2 and incur 1 disaster"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Search_Wreckage : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 2 scrap OR Add 6 scrap and incur 1 disaster"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Perishable_Food : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 1 food OR Add 2 scrap"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Oxygen_Tanks : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 2 O2 OR Add 3 scrap"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Drastic_Discovery : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Discover 1 cards OR Add 4 scrap"; } set { } }
    public override bool choice { get { return true; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Meager_Scavenge : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 1 food"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 1; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Underwater_Scavenge : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 3 food and incur 1 disaster"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 1; } set { } }
    public override int food_change { get { return 3; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Fortunate_Find : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 5 scrap"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 5; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Rendezvous : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Use to move another player to your tile."; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Rendezvous"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Distress_Call : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Use to move to a tile on theboard with another player."; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Distress_Call"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Unstable_Teleporter : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Use to move to any tile on the board and incur 1 disaster."; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Unstable_Teleporter"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 1; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Matter_Reorganizer : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "You may discard an item or part instead of consuming food for the turn."; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Matter_Reorganizer"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Oxygen_Sythesizer : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "You don’t consume O2"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Oxygen_Synthesizer"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Hidden_Cache : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Search the discovery pile for an item and discover it. Shuffle the discovery pile, and incur 1 disaster"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Hidden_Cache"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 1; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Power_Cell : DiscoveryCards
{
    public override int count { get { return 4; } set { } }
    public override string description { get { return ""; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Power Cell"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Reconstructor : DiscoveryCards
{
    public override int count { get { return 4; } set { } }
    public override string description { get { return "Use to revive a player on the same tile"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "Reconstructor"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Valuable_Find : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Search the discovery pile for a part and discover it. Shuffle the discovery pile, and incur 1 disaster."; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 1; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Fateful_Find : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Add 2 food, 2 O2, and 2 scrap"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 2; } set { } }
    public override int scrap_change { get { return 2; } set { } }
    public override int oxygen_change { get { return 2; } set { } }

}
public class False_Hope : DiscoveryCards
{
    public override int count { get { return 1; } set { } }
    public override string description { get { return "Incur 1 disaster"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 1; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 0; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Salvage : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 4 scrap"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return ""; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 4; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}
public class Meager_Salvage : DiscoveryCards
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Add 3 scrap"; } set { } }
    public override bool choice { get { return false; } set { } }
    public override string partType { get { return ""; } set { } }
    public override string itemType { get { return "False_Hope"; } set { } }
    public override int getDiscovery { get { return 0; } set { } }
    public override int incurDisaster { get { return 0; } set { } }
    public override int food_change { get { return 0; } set { } }
    public override int scrap_change { get { return 3; } set { } }
    public override int oxygen_change { get { return 0; } set { } }

}