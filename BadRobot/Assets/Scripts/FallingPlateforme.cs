using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlateforme : MonoBehaviour {
    
    public AudioClip sound;
    public int mass = 20;
    public Vector3 basePosition;

    // rotation
    public float x;
    public float y;
    public float z;

    private bool hasPlayed = false;

    // Use this for initialization
    private void Start()
    {
        basePosition = transform.position;
        x = transform.rotation.x;
        y = transform.rotation.y;
        z = transform.rotation.z;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!hasPlayed)
            {
                GetComponent<AudioSource>().PlayOneShot(sound);
                hasPlayed = true;
            }
            transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            transform.GetComponent<Rigidbody2D>().mass = mass;
        }
    }

    public void Reset()
    {
        transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        Quaternion rotation = new Quaternion(x, y, z, 1);
        transform.SetPositionAndRotation(basePosition,rotation);
        hasPlayed = false;
    }


}
