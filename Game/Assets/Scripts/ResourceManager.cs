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
    public Text Miners;
    public Text Turrets;

    public bool stop;

    private EnergyBar EnergyBar;
    private SpawnPlayers SpawnPlayers;
    private TurretSpawner TurretSpawner;
    // Use this for initialization
    void Start () {
        EnergyBar = FindObjectOfType<EnergyBar>();
        SpawnPlayers = FindObjectOfType<SpawnPlayers>();
        TurretSpawner = FindObjectOfType<TurretSpawner>();
        energyTracker = 0;
        metalTracker = 100;
        PlayerPrefs.GetFloat("Metal", metalTracker);
        PlayerPrefs.Save();
    }
	
	// Update is called once per frame
	void Update () {
        energyDisp.text = "Energy = " + energyTracker;
        metalDisp.text = "Metal = " + metalTracker;

        Miners.text = "Miners: " + SpawnPlayers.numOfMiners;
       Turrets.text = "Turrets: " + TurretSpawner.numOfTurrets;

        if(EnergyBar.EnergyStatus >= 1f)
        {
            levelInfo.text = "You have completed level 1!";
            stop = true;
            PlayerPrefs.SetFloat("Metal", metalTracker);
            PlayerPrefs.Save();
        }
        
	}
}
