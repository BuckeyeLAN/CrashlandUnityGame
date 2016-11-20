using UnityEngine;
using System.Collections;

abstract public class Tile
{
    abstract public int count { get; set; }
    abstract public string description { get; set; }
    abstract public int discover_count { get; set; }
    abstract public int disaster_count_on_end { get; set; }
    abstract public int disaster_count_on_find { get; set; }
    abstract public int oxygen_loss { get; set; }
    abstract public int food_loss { get; set; }
    abstract public int scrap_loss { get; set; }
    abstract public bool is_teleporter { get; set; }

    abstract public int boardX { get; set; }
    abstract public int boardY { get; set; }

    abstract public Tile copy();
}
