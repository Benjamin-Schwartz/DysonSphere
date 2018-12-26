using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour {
    public GameObject player;
    public StarterSphere StarterSphere;

    // Use this for initialization
    void Start () {
        StarterSphere = FindObjectOfType<StarterSphere>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && StarterSphere.minerShooting == true)
        {
            Instantiate(player,transform.position,transform.rotation);
        }

    }
}
