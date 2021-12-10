using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (this.transform.position.x > -4)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (this.transform.position.x < 4)
            {
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
