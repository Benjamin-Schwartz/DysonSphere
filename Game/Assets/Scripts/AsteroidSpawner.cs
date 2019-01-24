﻿using System.Collections;
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

    //circular spawning
    public int numnObjects = 10;
    public Vector3 center;
    




    public float spawnTime;
    public float currentTime;

	// Use this for initialization
	void Start () {
         center = transform.position;
        EnergyBar = FindObjectOfType<EnergyBar>();
        

         
}

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= spawnTime && EnergyBar.EnergyStatus < 1)
         {
            Vector3 pos = RandomCirlce(center, 4.5f);
            Instantiate(Asteroid, pos, transform.rotation);
            spawnTime -= .08f;
            currentTime = 0;
        
        }

   }
    Vector3 RandomCirlce(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius + Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return 
            pos;
    }
        }
    
   
