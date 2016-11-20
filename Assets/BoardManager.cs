using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

    public GameObject ship;
    public HashSet<GameObject> locationsInPlay;
    public HashSet<GameObject> locationsOpen;
    private Camera camera;
    private GameObject[] toDestroy;

    public void makeVisited(GameObject ob)
    {
        //Instatiate with texture/effect of tile
        GameObject visit = GameObject.Find("Tile");
        Instantiate(visit, ob.transform.position, ob.transform.rotation);

    }

    public void destroyGhostTiles()
    {
        foreach(GameObject ob in toDestroy)
        {
            Destroy(ob);
        }
    }


    public GameObject[] generateGhostTiles(GameObject hex)
    {
        GameObject ghost = GameObject.Find("GhostTile");
        GameObject[] ob = new GameObject[6];
        
        ob[0] = (GameObject)Instantiate(ghost, new Vector3(hex.transform.lossyScale.x * 0.5f + hex.transform.position.x, 0, hex.transform.lossyScale.x * 0.866f + hex.transform.position.z), hex.transform.rotation);
        ob[1] = (GameObject)Instantiate(ghost, new Vector3(hex.transform.lossyScale.x * 0.5f + hex.transform.position.x, 0, -hex.transform.lossyScale.x * 0.866f + hex.transform.position.z), hex.transform.rotation);
        ob[2] = (GameObject)Instantiate(ghost, new Vector3(hex.transform.lossyScale.x * -0.5f + hex.transform.position.x, 0, hex.transform.lossyScale.x * 0.866f + hex.transform.position.z), hex.transform.rotation);
        ob[3] = (GameObject)Instantiate(ghost, new Vector3(hex.transform.lossyScale.x * -0.5f + hex.transform.position.x, 0, -hex.transform.lossyScale.x * 0.866f + hex.transform.position.z), hex.transform.rotation);
        ob[4] = (GameObject)Instantiate(ghost, new Vector3(hex.transform.lossyScale.x + hex.transform.position.x, 0 , hex.transform.position.z), hex.transform.rotation);
        ob[5] = (GameObject)Instantiate(ghost, new Vector3(-hex.transform.lossyScale.x + hex.transform.position.x, 0, hex.transform.position.z), hex.transform.rotation);



        return ob;
    }


	// Use this for initialization
	void Start () {
        ship = GameObject.Find("Tile");
        locationsInPlay = new HashSet<GameObject>();
        locationsOpen = new HashSet<GameObject>();

        locationsOpen.Add(ship);
        toDestroy = generateGhostTiles(ship);
        camera = Camera.main;
        

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                makeVisited(hit.transform.gameObject);
                destroyGhostTiles();
                toDestroy = generateGhostTiles(hit.transform.gameObject);
            }
        }

    }

}

