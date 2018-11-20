using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public static int playerScore=0;
	public bool jump;
	GUIStyle smallFont;




	// Use this for initialization
	void Start () {
		smallFont = new GUIStyle();
		smallFont.fontSize = 32;
	}
	
	// Update is called once per frame



	void Update () {




				rigidbody2D.velocity = new Vector2 (10f, rigidbody2D.velocity.y);



				
		
				if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
						if (jump == true) {
								rigidbody2D.AddForce (new Vector2 (0, 550f));

								jump = false;
						}
				}
			
		}





	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Ground")
						jump = true;



		}


	void OnGUI()

	{

		GUI.Label (new Rect (10, 10, 100, 100), "SCORE: " + playerScore,smallFont);
	
	}

}
