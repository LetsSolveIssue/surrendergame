using UnityEngine;
using System.Collections;

public class CollideWithEnemy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{     
		if (other.gameObject.name == "Player")
		{				
			
			
			Move.playerScore=0;

			 
			Destroy(this.gameObject);
			Application.LoadLevel(1);
			
			
		}
		
		
		
		
	}


	}
