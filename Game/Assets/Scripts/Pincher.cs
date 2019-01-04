using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pincher : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float moveSpeed;
    private bool grappled; // This bool determines if a building is being grabbed by the pincher
    public GameObject planet; // The planet of the level
    public GameObject target; //The thing the pincher is trying to kill
    private GameObject childTarget; //Grabs target of pincher child
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, planet.transform.position) > 3 && grappled == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, planet.transform.position, moveSpeed * Time.deltaTime);

        }

        PincherTargeter childTarget = GetComponentInChildren<PincherTargeter>();
        target = childTarget.pinchtarget;

        if (target != null && grappled == false)
        {
            transform.SetParent(planet.transform);
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        }else if (grappled == true && target != null){
            transform.SetParent(null);
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, -1* moveSpeed * Time.deltaTime);
            

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == target)
        {
            //Debug.Log("GotOne");
            grappled = true;
            collision.transform.parent = gameObject.transform;
            StartCoroutine(Drop(2));
        }
    }

    IEnumerator Drop(float time)
    {
        
        yield return new WaitForSeconds(time);
        target.transform.parent = null;
        

    }
}
