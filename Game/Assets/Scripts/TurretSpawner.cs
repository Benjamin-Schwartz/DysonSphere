using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    public GameObject turret;
    public StarterSphere StarterSphere;
    private ResourceManager resourceManager;

    // Use this for initialization
    void Start()
    {
        StarterSphere = FindObjectOfType<StarterSphere>();
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && StarterSphere.turretShooting == true)
        {
            if (resourceManager.metalTracker >= 5)
            {
                Instantiate(turret, transform.position, transform.rotation);
                resourceManager.metalTracker -= 5;
            }
        }

    }
}
