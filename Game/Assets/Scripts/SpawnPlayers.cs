using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour {
    public GameObject player;
    public StarterSphere StarterSphere;
    private ResourceManager resourceManager;
    // Use this for initialization
    void Start () {
        StarterSphere = FindObjectOfType<StarterSphere>();
        resourceManager = FindObjectOfType<ResourceManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && StarterSphere.minerShooting == true)
        {
            if (resourceManager.metalTracker >= 10)
            {
                Instantiate(player, transform.position, transform.rotation);
                resourceManager.metalTracker -= 10;
            }
        }

    }
}
