using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour {
    public GameObject player;
    public StarterSphere StarterSphere;
    private ResourceManager resourceManager;

   private float currentTime;
    public float rechargeTime;
    private bool MinersActive;
    public int numOfMiners;
    private int maxMiners;
    // Use this for initialization
    void Start () {
        maxMiners = 10;
        numOfMiners = 5;
        StarterSphere = FindObjectOfType<StarterSphere>();
        resourceManager = FindObjectOfType<ResourceManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && StarterSphere.minerShooting == true)
        {
            if (numOfMiners > 0)
            {
                Instantiate(player, transform.position, transform.rotation);
                numOfMiners -= 1;
            }
           
            }
        if (currentTime < rechargeTime)
        {
            currentTime += Time.deltaTime;
            Debug.Log(currentTime);
            if (currentTime >= rechargeTime && numOfMiners < maxMiners)
            {
                numOfMiners += 1;
                currentTime = 0;
            }
           if(numOfMiners == maxMiners)
            {
                currentTime = 0;
            }
        }

    }


}
