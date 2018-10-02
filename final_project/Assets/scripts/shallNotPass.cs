using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shallNotPass : MonoBehaviour {
    public GameObject player;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "enemyProjectile")
        {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
