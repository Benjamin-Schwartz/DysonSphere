using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterSphere : MonoBehaviour {
    //public float rotationSpeed;
    public bool minerShooting;
    public bool turretShooting;
    // Use this for initialization
    void Start () {
        minerShooting = true;
		
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();

    }

    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
           
            transform.localRotation *= Quaternion.Euler(0, 0, 180);
            if (minerShooting == true)
            {
                minerShooting = false;
                turretShooting = true;
            }
            else
            {
               turretShooting = false;
                minerShooting = true;
            }
            }
        }
    }

