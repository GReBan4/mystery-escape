using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public GameObject door;
    // サウンド設定
    public AudioClip get;
    AudioSource audioSource;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Human")
        {
            door.GetComponent<door_src>().Open();
            Destroy(this.gameObject,1f) ;
            audioSource.PlayOneShot(get);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // AudioComponent取得
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = get;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
