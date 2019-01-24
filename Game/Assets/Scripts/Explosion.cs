using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Kill());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Kill()
    {
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
