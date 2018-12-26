using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {
    public int energyTracker;
    public Text energyDisp;
    public float metalTracker;
    public Text metalDisp;
	// Use this for initialization
	void Start () {

        energyTracker = 110;
        metalTracker = 5;
	}
	
	// Update is called once per frame
	void Update () {
        energyDisp.text = "Energy = " + energyTracker;
        metalDisp.text = "Metal = " + metalTracker;
	}
}
