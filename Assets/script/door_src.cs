using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_src : MonoBehaviour
{
    public GameObject door;
    Rigidbody rb;
    // サウンド設定
    AudioSource audioSource;
    public AudioClip doorOpen;
    public AudioClip doorClosed;

    // Start is called before the first frame update
    void Start()
    {
        rb = door.GetComponent<Rigidbody>();
        // AudioComponent取得
        audioSource = GetComponent<AudioSource>();
        
    }
    public void Open()
    {
        rb.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 衝突した際のサウンド設定
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Human")
        {
            audioSource.clip = doorClosed;
            audioSource.Play();
        }
    }
}
