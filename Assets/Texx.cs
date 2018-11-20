using UnityEngine;
using System.Collections;

public class Texx : MonoBehaviour {

	void OnGUI()
	{

		GUI.Label (new Rect ( Screen.width/2, Screen.height/2-50,100,50), "YOU LOSE");
		if (GUI.Button (new Rect (Screen.width/2, Screen.height/2, 100, 50), "REPLAY"))
						Application.LoadLevel (0);


	}
}
