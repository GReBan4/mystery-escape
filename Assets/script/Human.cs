using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Human : MonoBehaviour
{
    // サウンド設定
    AudioSource audioSource;
    public AudioClip doorOpen;
    public AudioClip doorClosed;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "QBox1")
        {
            SceneManager.LoadScene("Q-Scenes");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // AudioComponent取得
        audioSource = GetComponent<AudioSource>();
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
