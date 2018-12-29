using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketTargeting : MonoBehaviour
{
    public float moveSpeed;
    public bool chasing;
    public GameObject rocketTarget;
    private Vector3 enemyLoc;
    // Start is called before the first frame update
    void Start()
    {
        chasing = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (rocketTarget!= null)
        {
            MovingTowards(rocketTarget);
            enemyLoc = rocketTarget.transform.position;
            var dir = enemyLoc - transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 270;
            //angle -=270;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }
        else
        { 
          //  Destroy(gameObject);
        }
        
    }

    public void MovingTowards(GameObject target)
    {
        
      transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
         Destroy(gameObject);
        }
    }
}
