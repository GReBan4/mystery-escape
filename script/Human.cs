using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0.0f, 0.0f, 0.05f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0.0f, 0.0f, -0.05f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0.05f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-0.05f, 0.0f, 0.0f);
        }
    }
}
