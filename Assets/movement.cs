using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public Rigidbody2D stone;
	public Transform blast;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		transform.localScale = new Vector3(0.2f, 0.2f);

		StartCoroutine(playblast());


	}




	IEnumerator playblast()
	{ yield return new WaitForSeconds(0.5f);
		blast.position = transform.position;

	}
	// Update is called once per frame
	void Update () {
	
		transform.Translate(0.03f,0,0);
		if(transform.position.x >= stone.rigidbody2D.transform.position.x)
		{
			Debug.Log("gg");
			stone.rigidbody2D.gravityScale = 2;
		}



	}
}
