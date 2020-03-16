using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reprendre : MonoBehaviour {

    public Vector2 position;
    public GameObject[] platforms;
    public GameObject[] ennemis;

    public void Start()
    {
        platforms = GameObject.FindGameObjectsWithTag("Falling Platform");
        ennemis = GameObject.FindGameObjectsWithTag("Ennemi");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = position;

            foreach (GameObject x in platforms)
            {
                FallingPlateforme fp = x.GetComponent<FallingPlateforme>();
                fp.Reset();
            }

           /* foreach (GameObject y in ennemis)
            {
                EnnemiIA e = y.GetComponent<EnnemiIA>();
                e.Reset();
            }*/

        }
    }

    public void changeP(float m, float n)
    {
        position.x = m;
        position.y = n;
    }
}
