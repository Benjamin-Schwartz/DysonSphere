using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBullet : MonoBehaviour
{
    private TargetFinder TargetFinder;
    // Start is called before the first frame update
    void Start()
    {
        TargetFinder = FindObjectOfType<TargetFinder>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TargetFinder.clickedTarget != null && TargetFinder.clickedTarget.tag == "Enemy")
        {
            transform.position = Vector2.MoveTowards(transform.position, TargetFinder.clickedTarget.transform.position, 10 * Time.deltaTime);
        }
        
            else
        {
            Destroy(gameObject);
            }
        }
    
}
