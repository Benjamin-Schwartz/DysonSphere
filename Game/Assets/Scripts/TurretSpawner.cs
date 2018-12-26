using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    public GameObject turret;
    public StarterSphere StarterSphere;

    // Use this for initialization
    void Start()
    {
        StarterSphere = FindObjectOfType<StarterSphere>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && StarterSphere.turretShooting == true)
        {
            Instantiate(turret, transform.position, transform.rotation);
        }

    }
}
