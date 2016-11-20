using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        TextAsset targetFile = Resources.Load("Tile") as TextAsset;
        Debug.Log(targetFile);
        List<Tile> thing = JsonUtility.FromJson<List<Tile>>(targetFile.text);
        Debug.Log(thing.Count);
        foreach (Tile test in thing)
        {
            Debug.Log(test);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
