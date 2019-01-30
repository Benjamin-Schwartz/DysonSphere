using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    public GameObject turret;
    public StarterSphere StarterSphere;
    private ResourceManager resourceManager;
    private MouseClick MouseClick;

    private float currentTime;
    public float rechargeTime;
    public int numOfTurrets;
    private int maxTurrets;

    // Use this for initialization
    void Start()
    {
        //maxTurrets = 10;
        //numOfTurrets = 3;
        StarterSphere = FindObjectOfType<StarterSphere>();
        resourceManager = FindObjectOfType<ResourceManager>();
        MouseClick = FindObjectOfType<MouseClick>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space") && StarterSphere.turretShooting == true)
        {
            if (MouseClick.Schwartzconium >=50)
            {
                Instantiate(turret, transform.position, transform.rotation);
                MouseClick.Schwartzconium -= 50;
               // numOfTurrets -= 1;
            }

        }
        /*if (currentTime < rechargeTime)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= rechargeTime && numOfTurrets < maxTurrets)
            {
                numOfTurrets += 1;
                currentTime = 0;
            }
            if (numOfTurrets == maxTurrets) 
            {
                currentTime = 0;
            }
        }
        */
    }


}