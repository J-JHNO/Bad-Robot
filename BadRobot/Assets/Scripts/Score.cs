using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int piles = 0;
    public GUISkin labelSkin;
    
	void OnGUI () {
        GUI.skin = labelSkin;
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 5, 300, 50), "Score : " + piles);
	}
	
}
