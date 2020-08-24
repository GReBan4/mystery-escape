using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public GameObject door;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Human")
        {
            door.GetComponent<door_src>().Open();
            Destroy(this.gameObject,1f) ;
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
