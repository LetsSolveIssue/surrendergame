using UnityEngine;
using System.Collections;

public class CollideWithCube : MonoBehaviour {


	IEnumerator OnCollisionEnter2D(Collision2D other)
	{     
		if (other.gameObject.name == "Player")
		{				


			Move.playerScore++;
			audio.Play();
			yield return new WaitForSeconds(0.05f);
			Destroy(this.gameObject);


		
		}



	
	}
}