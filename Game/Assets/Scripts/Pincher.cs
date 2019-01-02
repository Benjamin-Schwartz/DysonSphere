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
        if (Vector2.Distance(transform.position, planet.transform.position) > 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, planet.transform.position, moveSpeed * Time.deltaTime);

        }

        PincherTargeter childTarget = GetComponentInChildren<PincherTargeter>();
        target = childTarget.pinchtarget;

        if(target != null)
        {
            transform.SetParent(planet.transform);
        }
    }
}
