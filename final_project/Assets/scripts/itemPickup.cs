using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour {

    Rigidbody rb;
    public float rotateSpeed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(1, 1, 1) * rotateSpeed, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5f)
        {
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(Random.Range(-10, 20), 4, Random.Range(-10, 20));
        }

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            col.gameObject.tag = "Player_with_ak";
        }
        
    }
}
