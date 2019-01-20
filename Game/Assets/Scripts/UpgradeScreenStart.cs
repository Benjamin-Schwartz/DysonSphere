using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScreenStart : MonoBehaviour
{
    public Text metalCount;
    public float metal;
    // Start is called before the first frame update
    void Start()
    {
        metal = PlayerPrefs.GetFloat("Metal");
        metalCount.text = "Metal: " + metal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
