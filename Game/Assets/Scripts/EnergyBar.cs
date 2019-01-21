using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    public Transform bar;
    public float EnergyStatus;
    private void Start()
        
    {
        EnergyStatus = 0;
        Transform bar = transform.Find("Bar");
        bar.localScale = new Vector3(0f, 0f);
        
    }

    void Update()
    {
        bar.localScale = new Vector3(EnergyStatus, 1f);
    }
    public void setSize(float EnergyStatus)
    {
        bar.localScale = new Vector3(EnergyStatus, 1f);
    }
    
}
