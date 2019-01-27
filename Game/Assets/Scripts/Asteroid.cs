using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    public float maxHealth;
    public float currentHealth;
    private bool isStuck;

    public GameObject Target;
    public GameObject explosion;

    //EnergyBar stuff
    private EnergyBar EnergyBar;

    private cameraShake cameraShake;
    // Use this for initialization
    void Start()
    {
        EnergyBar = FindObjectOfType<EnergyBar>();
        isStuck = false;
        cameraShake = FindObjectOfType<cameraShake>();
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStuck == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
            transform.Rotate(0, 0, 0.75f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rocket") { 
        if ( EnergyBar.EnergyStatus < .5f)
        {
            currentHealth -= 25;

        } if ( EnergyBar.EnergyStatus > .6f)
        {
            currentHealth -= 15;
        }
            if (currentHealth <= 0)
            {
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        if (collision.tag == "Circle")
        {
            isStuck = true;
            transform.SetParent(collision.transform);
            gameObject.tag = "Obstacle";
            EnergyBar.EnergyStatus = 0;
        }
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Shield")
        {
            Destroy(gameObject);
        }

    }
}
