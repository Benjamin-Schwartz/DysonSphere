using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidSpawner : MonoBehaviour {
    public GameObject Asteroid;
    public float xDistance;
    public float yDistance;
    private Vector3 spawnLoc;
    public Text waveText;
    public int Wave;
    public int numberOfEnemies;
    public bool stop;
    public float buildTime;
    public float initialbuildTime;
    private EnergyBar EnergyBar;



    public float spawnTime;
    public float currentTime;

	// Use this for initialization
	void Start () {
       
    EnergyBar = FindObjectOfType<EnergyBar>();

}

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= spawnTime && EnergyBar.EnergyStatus < 1)
         {
        Instantiate(Asteroid, new Vector2(Random.Range(-xDistance, xDistance)+ 3, Random.Range(-yDistance, yDistance) + 3), Quaternion.identity);
         currentTime = 0;
        
        }

   }
   

        }
    
   
