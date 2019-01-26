using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UtilityMenu : MonoBehaviour
{
    
    public GameObject a;
    public UpgradeScreenStart mainControl;

    public int mineSpeedUpgrades = 0;
    public int buildTimeUpgrades = 0;
    


    void Start()
    {
       
        mainControl = a.GetComponent<UpgradeScreenStart>();
    }
    public void IncreaseMineSpeed()
        
    {
        
        mineSpeedUpgrades += 1;
        mainControl.metaltemp -= 10* (mineSpeedUpgrades + PlayerPrefs.GetFloat("MineSpeed", 1));
        mainControl.metalCount.text = "Metal " + mainControl.metaltemp;
       
        
    }

    public void IncreaseBuildTime()

    {
        Debug.Log(mineSpeedUpgrades);
        buildTimeUpgrades += 1;
        mainControl.metaltemp -= 5 * (mineSpeedUpgrades + PlayerPrefs.GetFloat("MineSpeed", 1));
        mainControl.metalCount.text = "Metal " + mainControl.metaltemp;


    }

    public void Apply()
    {
        // If apply is hit, metal is subtracted, set new values. 

        // 0.5f multiply just so minespeed doesn't get crazy. each upgrade upgrades by 0.5f. base value is 1.
        PlayerPrefs.SetFloat("MineSpeed", 0.5f*mineSpeedUpgrades + PlayerPrefs.GetFloat("MineSpeed", 1f));
        PlayerPrefs.SetFloat("BuildSpeed", buildTimeUpgrades + PlayerPrefs.GetFloat("MineSpeed", 1f));
        mainControl.metal = mainControl.metaltemp;


        //setting upgrade tracker values back to base
        mineSpeedUpgrades = 0;
        buildTimeUpgrades = 0;
    }

    public void CloseLocal()
    {
        mineSpeedUpgrades = 0;
        Debug.Log(mineSpeedUpgrades);
        mainControl.metaltemp = mainControl.metal;
    }
}
