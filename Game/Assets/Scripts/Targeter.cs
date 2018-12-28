using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeter : MonoBehaviour { 

    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            counter += 1;
            if (counter == 1)
            {

            }
            transform.SetParent(collision.transform);
            
            //collision.gameObject
        }
    }

}
