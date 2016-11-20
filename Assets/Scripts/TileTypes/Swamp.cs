using UnityEngine;
using System.Collections;
using System;

public class Swamp : Tile
{
    public override int count { get { return 2; } set { } }
    public override string description { get { return "Lose 1 scrap if you end your turn here; Discover 1 card"; } set { } }
    public override int discover_count { get { return 1; } set { } }
    public override int disaster_count_on_end { get { return 0; } set { } }
    public override int disaster_count_on_find { get { return 0; } set { } }
    public override int oxygen_loss { get { return 0; } set { } }
    public override int food_loss { get { return 0; } set { } }
    public override int scrap_loss { get { return 1; } set { } }
    public override bool is_teleporter { get { return false; } set { } }
    public override int boardX { get; set; }
    public override int boardY { get; set; }

    public override Tile copy()
    {
        return new Swamp();
    }
}
