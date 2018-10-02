using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public GameObject player;
    private float damage;
    private float range;
    public Camera fpsCam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.tag == "Player_with_ak")
        {
            damage = 10f;
            range = 100f;
        }

        if (player.tag != "Player" && Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
