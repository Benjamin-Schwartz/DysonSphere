using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    public Transform bar;
    public float EnergyStatus;
    // Start is called before the first frame update
    private void Start()
        
    {
        EnergyStatus = 0;
        Transform bar = transform.Find("Bar");
        bar.localScale = new Vector3(0f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
       // Transform bar = transform.Find("Bar");
        bar.localScale = new Vector3(EnergyStatus, 1f);
    }
    public void setSize(float EnergyStatus)
    {
        bar.localScale = new Vector3(EnergyStatus, 1f);
    }
    
}
