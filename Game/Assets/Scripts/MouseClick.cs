using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private ResourceManager resourceManager;
    public GameObject clickSelection;
    // Start is called before the first frame update
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //This method returns the game object that was clicked using Raycast 2D


        /// TOUCH CONTROL CHANGE
        if (Input.GetMouseButtonDown(0))
        ///TOUCH CONTROL CHANGE
        {
            clickSelection=ClickSelect();
            Debug.Log(clickSelection);
                if(clickSelection.transform.tag == "Notification" && clickSelection.GetComponent<Renderer>().enabled == true)
            {
                clickSelection.GetComponent<Renderer>().enabled = false;
                resourceManager.metalTracker += 5;
            }

        

        }


    }
    GameObject ClickSelect()
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
}
