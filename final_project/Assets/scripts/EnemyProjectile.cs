using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "impassible surroundings")
        {
            Destroy(gameObject);
        } else if(collision.transform.tag == "Player_with_ak")
        {
            Debug.Log("hit player");
            playerMove player = collision.transform.GetComponent<playerMove>();
            player.takeDamage(20f);
            Destroy(gameObject);
        }
    }
}
