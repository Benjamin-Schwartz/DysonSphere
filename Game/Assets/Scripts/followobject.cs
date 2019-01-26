using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followobject : MonoBehaviour
{
    public GameObject followThis;
    public GameObject planet;
    public bool isStuck = false;
    private bool gathering = false;
    public Rigidbody2D rb;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0f, 5f);
        planet = GameObject.FindGameObjectWithTag("Circle");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStuck)
        {
            transform.position = new Vector3(followThis.transform.position.x, followThis.transform.position.y-0.5f , 0);
        }
    
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            
            isStuck = true;
            gathering = true;
           // transform.position = new Vector3(transform.position.x, -1.0f, transform.position.z);
        }
    }
}
