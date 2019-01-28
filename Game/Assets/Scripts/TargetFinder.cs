using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetFinder : MonoBehaviour
{
    public GameObject clickedTarget;
    private bool hasTarget;
    private GameObject circle;
    public GameObject Spacebullet;
    public GameObject spawnPoint;
    private GameObject SpaceClone;
    public GameObject ReturnPoint;

    private bool shooting;
    public float ShootSpeed;
    public float CurrentTime;

    // Start is called before the first frame update
    void Start()
    {
       circle = GameObject.FindGameObjectWithTag("Circle");
        clickedTarget = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            clickedTarget = targetSelect();
            if (clickedTarget.transform.tag == "Enemy")
            {
                hasTarget = true;
            }
            else
            {
                hasTarget = false;
                transform.position = Vector2.MoveTowards(transform.position, ReturnPoint.transform.position, 2 * Time.deltaTime);
                return;
            }
           
        }
        //  if (clickedTarget != null && clickedTarget.transform.tag == "Enemy" || clickedTarget.transform.tag == "Obstacle")
        //  {
        if (clickedTarget != null)
        {
            MoveToEnemy();
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, ReturnPoint.transform.position, 2 * Time.deltaTime);
        }

       // }
        CurrentTime += Time.deltaTime;
        if (CurrentTime >= ShootSpeed && clickedTarget != null)
        {
          
          Instantiate(Spacebullet, spawnPoint.transform.position, transform.rotation);
            CurrentTime = 0;
        }
       
    }

    GameObject targetSelect()
    {
        //This method returns the game object that was clicked using Raycast 2D
        //Converting Mouse Pos to 2D (vector2) World Pos
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
            //Debug.Log(hit.transform.name);
            return hit.transform.gameObject;
        }
        else return null;
    }
    void MoveToEnemy()
    {
            transform.position = Vector2.MoveTowards(transform.position, clickedTarget.transform.position, 2 * Time.deltaTime);
    }
}
