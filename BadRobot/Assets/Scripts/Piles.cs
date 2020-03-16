using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piles : MonoBehaviour {
    
    private Score score;
    private bool hasPlayed = false;
    

    // Use this for initialization
    void Start () {
        score = (Score)GameObject.FindGameObjectWithTag("Player").GetComponent("Score");
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player")
        {
            if (!hasPlayed)
            {
                score.piles += 1;
                hasPlayed = true;
                
            }

            Destroy(gameObject);
        }
	}

    public void Reset()
    {
        
        hasPlayed = false;
    }
}
