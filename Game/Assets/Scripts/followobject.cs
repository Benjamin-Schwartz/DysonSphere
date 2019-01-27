using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followobject : MonoBehaviour
{
    public GameObject followThis;
    public GameObject planet;
    public bool notifIsStuck = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        planet = GameObject.FindGameObjectWithTag("Circle");
    }

    // Update is called once per frame
    void Update()
    {
        if (!notifIsStuck)
        {
            transform.position = new Vector3(followThis.transform.position.x, followThis.transform.position.y-0.5f , 0);
        }
    
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            
            
            notifIsStuck = true;
           
           // transform.position = new Vector3(transform.position.x, -1.0f, transform.position.z);
        }
    }
}
