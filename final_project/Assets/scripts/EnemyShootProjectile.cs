using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootProjectile : MonoBehaviour {

    public Rigidbody EnemyProjectile;
    public Transform barrelEnd;
    private int timer;
    public int TargetTimer;
    public int projectileSpeed;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer < TargetTimer)
        {
            timer++;
        } else
        {
            timer = 0;
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(EnemyProjectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.forward * projectileSpeed);
        }
		
	}
}
