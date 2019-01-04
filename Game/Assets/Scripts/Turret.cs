using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float moveSpeed;
    public bool isStuck = false;
    public bool falling = false;
    void Start()
    {
        StartCoroutine(KillPlayer());
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isStuck && falling == false)
        {
            transform.Translate(0, moveSpeed, 0);
        }
        else if (falling == true && gameObject.transform.parent == null)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, 0), 5 * Time.deltaTime);
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
        if (collision.tag == "Circle" && !falling)
        {
            if (!isStuck)
            {
                transform.SetParent(collision.transform);
                transform.localRotation *= Quaternion.Euler(0, 0, 180);
                isStuck = true;
                transform.position = new Vector3(transform.position.x, -1.45f, transform.position.z);
            }
            else if (collision.tag == "Player" || collision.tag == "Circle" && falling)
            {
                Destroy(gameObject);
            }

        }
        else if (collision.tag == "Enemy")
        {
            isStuck = false;
            falling = true;
        }
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            
        }
    }
}
