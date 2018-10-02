using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour {

    Rigidbody rb;
    public float startHealth = 50f;
    private float health;
    public float rotateSpeed;
    private int timer;
    private int targetTimer;

    public Image healthBar;

    private void Start()
    {
        health = startHealth;
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(0, 1, 0) * rotateSpeed, ForceMode.Impulse);
        timer = 0;
        targetTimer = Random.Range(400, 800);
    }

    private void Update()
    {
        if (timer < targetTimer)
        {
            timer++;

        }
        else
        {
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(Random.Range(-10, 20), 1.5f, Random.Range(-10, 20));
            timer = 0;
            targetTimer = Random.Range(50, 100);
        }
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }


	
}
