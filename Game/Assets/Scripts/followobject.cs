using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followobject : MonoBehaviour
{
    public GameObject followThis;
    public GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Circle");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (followThis.transform.position.x, followThis.transform.position.y - 0.2f,0);
        if (gameObject.activeSelf)
        {
            transform.SetParent(planet.transform);
        }
    }
}
