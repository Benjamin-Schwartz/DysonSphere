using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public float speed;
    public float maxHealth;
    public float currentHealth;

    public GameObject Target;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            currentHealth -= 5;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
