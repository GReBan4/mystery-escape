using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBox : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(CompareTag("QBox"))
        {
            Debug.Log("HIT");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
