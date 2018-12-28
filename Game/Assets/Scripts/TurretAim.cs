﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAim : MonoBehaviour
{
    Collider2D turretCollider;
    public Turret turret;
    private Vector3 enemyLoc;
    public bool looking;
    private GameObject target;
    public GameObject pin;
    private bool deployed;
    // Start is called before the first frame update
    void Start()
    {
        turret = FindObjectOfType<Turret>();
        turretCollider = GetComponent<Collider2D>();
        turretCollider.enabled = !turretCollider.enabled;
        looking = true;
        deployed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (turret.isStuck && deployed ==false )
        {
            turretCollider.enabled =!turretCollider.enabled;
            deployed = true;
        }
        if (looking == false)
        {
            enemyLoc = target.transform.position;
            var dir = enemyLoc - transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg -270;
            //angle -=270;
            pin.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && looking==true)
        {
            //Debug.Log("GotOne");
            looking = false;
            target = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
     if (other.gameObject == target)
        {

            //Debug.Log("Buh Bye");
            looking = true;
        }

     
       // looking = true;
        //target = null;
    }
}
