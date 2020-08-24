using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_src : MonoBehaviour
{
    public GameObject door;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = door.GetComponent<Rigidbody>();
    }
    public void Open()
    {
        rb.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
