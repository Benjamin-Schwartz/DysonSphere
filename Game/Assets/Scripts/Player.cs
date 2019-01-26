using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private ResourceManager resourceManager;
    public float moveSpeed;
    private bool isStuck = false;
    private bool gathering = false;
    public Rigidbody2D rb;
    private Vector2 velocity;
    //Energy bar stuff
    private EnergyBar EnergyBar;

    public float mineSpeed;
    public GameObject notification; 


    public bool falling = false; //If a player is picked up by a pincher, and then dropped.
	void Start () {
        StartCoroutine(KillPlayer());
        EnergyBar = FindObjectOfType<EnergyBar>();
        resourceManager = FindObjectOfType<ResourceManager>();
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0f, 5f);
        mineSpeed=PlayerPrefs.GetFloat("MineSpeed", 1);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!isStuck && !falling)
        {
            //transform.Translate(0, moveSpeed, 0);
            rb.MovePosition(rb.position + velocity  * (Time.fixedDeltaTime));

        }else if (falling == true && gameObject.transform.parent==null)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(0,0), 5 * Time.deltaTime);
        }
        if (gathering)
        {
            StartCoroutine(Gather(1));
            gathering = false;
            
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
        if (collision.tag == "Circle" && !falling)
        {
            transform.SetParent(collision.transform);
            isStuck = true;
            gathering = true;
           transform.position = new Vector3(transform.position.x, -1.45f, transform.position.z);
        }
    else if (collision.tag == "Player" || collision.tag == "Circle" && falling)
        {
            Destroy(gameObject);
        }
    else if(collision.tag == "Enemy")
        {
            isStuck = false;
            gathering = false;
            falling = true;
        }
    }

    IEnumerator Gather(float time)
    {
        yield return new WaitForSeconds(time);

        resourceManager.metalTracker += mineSpeed;
        notification.SetActive(true);

        if (EnergyBar.EnergyStatus < 1)
        {
            EnergyBar.EnergyStatus += .01f;
        }
        gathering = true;
        
    }

}
