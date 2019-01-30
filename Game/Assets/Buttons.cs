using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Starter;
    private StarterSphere StarterSphere;
    // Start is called before the first frame update
    void Start()
    {
        StarterSphere = FindObjectOfType<StarterSphere>();
    }
   public void Miners()
    {
        Starter.transform.localRotation = Quaternion.Euler(0, 0, 0);
        StarterSphere.turretShooting = false;
        StarterSphere.minerShooting = true;
    }
   public void Turrets()
    {
        Starter.transform.localRotation = Quaternion.Euler(0, 0, 180);
        StarterSphere.minerShooting = false;
        StarterSphere.turretShooting = true;
    }
}
