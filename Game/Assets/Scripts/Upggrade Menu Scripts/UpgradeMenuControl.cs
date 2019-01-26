using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenuControl : MonoBehaviour
{
    public GameObject utilityUpgrades;
    public GameObject mainMenu;
    public GameObject attackUpgrades;
    public GameObject defenseUpgrades;
    public List<GameObject> menus;

    public GameObject a;
    public UpgradeScreenStart mainControl;
    // Start is called before the first frame update
    void Start()
    {
        mainControl = a.GetComponent<UpgradeScreenStart>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UtilityMenu(){
        utilityUpgrades.SetActive(true);
        menus.Add(utilityUpgrades);
        mainMenu.SetActive(false);
    
        }
    public void AttackMenu()
    {
        utilityUpgrades.SetActive(false);
    }
    public void DefenseMenu()
    {
        utilityUpgrades.SetActive(false);
    }

    public void Apply()
    {
        mainControl.metal = mainControl.metaltemp;
    }
    public void Close() //Close without applying. Metal goes back to normal
    {
        mainControl.metalCount.text = "Metal: " + mainControl.metal;
        foreach (GameObject obj in menus)
        {
            obj.SetActive(false);
        }
        mainMenu.SetActive(true);
    }
}
