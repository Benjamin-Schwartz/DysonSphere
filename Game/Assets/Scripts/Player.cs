using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private ResourceManager resourceManager;
    public float moveSpeed;
    private bool isStuck = false;
    private bool gathering = false;
    public Rigidbody2D rb;
    private Vector2 velocity;
	void Start () {
        StartCoroutine(KillPlayer());
        resourceManager = FindObjectOfType<ResourceManager>();
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0f, 5f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!isStuck)
        {
            //transform.Translate(0, moveSpeed, 0);
            rb.MovePosition(rb.position + velocity  * (Time.fixedDeltaTime));

        }
        if (gathering)
        {
            StartCoroutine(Gather(1));
            gathering = false;
            
        }
        
    }
     
    IEnumerator KillPlayer()
    {
        yield return new WaitForSeconds(2);
        if (!isStuck)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            transform.SetParent(collision.transform);
            isStuck = true;
            gathering = true;
           transform.position = new Vector3(transform.position.x, -1.45f, transform.position.z);
        }
    if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Gather(float time)
    {
        yield return new WaitForSeconds(time);
        resourceManager.metalTracker += 1;
        gathering = true;
        
    }

}
