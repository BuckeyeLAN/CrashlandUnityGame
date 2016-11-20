using UnityEngine;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

    public int food = 0;
    public int oxygen = 0;
    public int scrap = 0;
    public List<string> inventory = new List<string>();
    public int coreParts = 0;
    public bool teleporterAssembled = false;
    public bool aiCoreAssembled = false;
    public bool transposerAssembled = false;
    public bool cryopodsAssembled = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
