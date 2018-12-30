using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float moveSpeed;
    public bool isStuck = false;
    void Start()
    {
        StartCoroutine(KillPlayer());
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isStuck)
        {
            transform.Translate(0, moveSpeed, 0);
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
            if (!isStuck)
            {
                transform.SetParent(collision.transform);
                transform.localRotation *= Quaternion.Euler(0, 0, 180);
                isStuck = true;
                transform.position = new Vector3(transform.position.x, -30f, transform.position.z);
            }
         
         }
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("ouch");
        }
    }
}
