using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float rotationSpeed;
    private ResourceManager resourceManager;

    // Use this for initialization
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(!resourceManager.stop)
        transform.Rotate(0, 0, rotationSpeed);

        //} 
    }
}
