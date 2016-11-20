using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public int food = 0;
    public int oxygen = 0;
    public int scrap = 0;
    public List<DiscoveryCard> inventory = new List<DiscoveryCard>();

    public int[] location = new int[] { 0, 0 };


	// Use this for initialization
	void Start () {
        //GetComponent<SpriteRenderer>().color = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    void addFood(int num)
    {
        food += num;
    }
    void addOxygen(int num)
    {
        oxygen += num;
    }
    void addScrap(int num)
    {
        scrap += num;
    }
    void addItem(DiscoveryCard discovery)
    {
        inventory.Add(discovery);
    }
    void removeItem(DiscoveryCard discovery)
    {
        inventory.Remove(discovery);
    }
}
