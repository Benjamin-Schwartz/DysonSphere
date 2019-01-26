using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScreenStart : MonoBehaviour
{
    public Text metalCount;
    public float metal;     // The amount of metal there is at the end of a level
    public float metaltemp; //The temporary display of metal before upgrades are applied
    // Start is called before the first frame update
    void Start()
    {
        //Set Values in PlayerPrefs
        PlayerPrefs.SetFloat("MineSpeed", PlayerPrefs.GetFloat("MineSpeed", 1f));
        PlayerPrefs.SetFloat("BuildTime", PlayerPrefs.GetFloat("MineSpeed", 1f));

        // Temporary! Delete When main menu is created!!!
        PlayerPrefs.SetFloat("MineSpeed", 1);


        metal = PlayerPrefs.GetFloat("Metal");
        metalCount.text = "Metal: " + metal;
        metaltemp = metal;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
