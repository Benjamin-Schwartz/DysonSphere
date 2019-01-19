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

        if (collision.gameObject.tag == "Rocket")
        {
            currentHealth -= 25;
            if (currentHealth <= 0)
            {
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
    }
}
