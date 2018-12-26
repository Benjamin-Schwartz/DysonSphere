using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float moveSpeed;
    private bool isStuck = false;
    void Start()
    {
        StartCoroutine(KillPlayer());
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStuck)
        {
            transform.Translate(0, moveSpeed, 0);
        }
    }
    IEnumerator KillPlayer()
    {
        yield return new WaitForSeconds(2);
        if (!isStuck)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            transform.SetParent(collision.transform);
            transform.localRotation *= Quaternion.Euler(0, 0, 180);
            isStuck = true;
        }
    }
}
