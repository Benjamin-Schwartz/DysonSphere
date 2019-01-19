using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {
    public int energyTracker;
    public Text energyDisp;
    public float metalTracker;
    public Text metalDisp;
    public Text levelInfo;

    public bool stop;

    private EnergyBar EnergyBar;
    // Use this for initialization
    void Start () {
        EnergyBar = FindObjectOfType<EnergyBar>();
        energyTracker = 0;
        metalTracker = 100;
	}
	
	// Update is called once per frame
	void Update () {
        energyDisp.text = "Energy = " + energyTracker;
        metalDisp.text = "Metal = " + metalTracker;
        if(EnergyBar.EnergyStatus >= 1f)
        {
            levelInfo.text = "You have completed level 1!";
            stop = true;
        }
        
	}
}
