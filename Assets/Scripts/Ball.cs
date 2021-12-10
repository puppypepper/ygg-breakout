using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody myRigid;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, Random.Range(-45,46), 0));
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce(transform.forward * speed, ForceMode.VelocityChange); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
