using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PincherTargeter : MonoBehaviour
{
    public GameObject pinchtarget; //target that the pincher wants to attack
    bool looking; //determines if a target has been found
    // Start is called before the first frame update
    void Start()
    {
        looking = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && looking == true)
        {

           // Debug.Log("GotOne");

            looking = false;
            pinchtarget = collision.gameObject;
            StartCoroutine(Drop(2));

        }
    }

    IEnumerator Drop(float time)
    {

        yield return new WaitForSeconds(time);

        //Debug.Log("Called");

        looking = true;

    }

}
