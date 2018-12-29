using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private ResourceManager resourceManager;
    public float moveSpeed;
    private bool isStuck = false;
    private bool gathering = false;
	void Start () {
        StartCoroutine(KillPlayer());
        resourceManager = FindObjectOfType<ResourceManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!isStuck)
        {
            transform.Translate(0, moveSpeed, 0);
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
        }
    
    }

    IEnumerator Gather(float time)
    {
        yield return new WaitForSeconds(time);
        resourceManager.metalTracker += 1;
        gathering = true;
        
    }

}
