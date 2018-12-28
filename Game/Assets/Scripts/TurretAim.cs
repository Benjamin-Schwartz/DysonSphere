using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAim : MonoBehaviour
{
    Collider2D turretCollider;
    public Turret turret;
    // Start is called before the first frame update
    void Start()
    {
        turret = FindObjectOfType<Turret>();
        turretCollider = GetComponent<Collider2D>();
        turretCollider.enabled = !turretCollider.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (turret.isStuck)
        {
            turretCollider.enabled =!turretCollider.enabled;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("GotOne");
            transform.LookAt(new Vector3(0, 0, collision.gameObject.transform.position.z));
        }
    }
}
