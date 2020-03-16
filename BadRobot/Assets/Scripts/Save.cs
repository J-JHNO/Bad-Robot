using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject[] deathObjects = GameObject.FindGameObjectsWithTag("Death");
            foreach (GameObject g in deathObjects)
            {
                Reprendre r = (Reprendre)g.GetComponent("Reprendre");
                r.changeP(transform.position.x, transform.position.y + 1);
            }
        }

        Destroy(gameObject);
    }
}
