using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {
    public GameObject Asteroid;
    public float xDistance;
    public float yDistance;
    private Vector3 spawnLoc;
    public bool stop;

    public float spawnTime;
    public float currentTime;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
       
            if (currentTime >= spawnTime)
            {
               // spawnLoc = new Vector3(Random.Range(-xDistance, xDistance), Random.Range(-yDistance, yDistance), 0);
                Instantiate(Asteroid, new Vector2(Random.Range(-xDistance, xDistance), Random.Range(-yDistance, yDistance)), Quaternion.identity);
            currentTime = 0;
        }

       
        
    }
   
}
