using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UtilityMenu : MonoBehaviour
{
    
    public GameObject a;
    public UpgradeScreenStart mainControl;

    public int mineSpeedUpgrades = 0;
    


    void Start()
    {
       
        mainControl = a.GetComponent<UpgradeScreenStart>();
    }
    public void IncreaseMineSpeed()
        
    {
        Debug.Log(mineSpeedUpgrades);
        mineSpeedUpgrades += 1;
        mainControl.metaltemp -= 10* (mineSpeedUpgrades + PlayerPrefs.GetFloat("MineSpeed", 1));
        mainControl.metalCount.text = "Metal " + mainControl.metaltemp;
       
        
    }

    public void Apply()
    {
        PlayerPrefs.SetFloat("MineSpeed", 0.5f*mineSpeedUpgrades + PlayerPrefs.GetFloat("MineSpeed", 1f));
        mainControl.metal = mainControl.metaltemp;


        mineSpeedUpgrades = 0;
        Debug.Log(PlayerPrefs.GetFloat("MineSpeed", 1f));
    }

    public void CloseLocal()
    {
        mineSpeedUpgrades = 0;
        Debug.Log(mineSpeedUpgrades);
        mainControl.metaltemp = mainControl.metal;
    }
}
