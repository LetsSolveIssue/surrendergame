using UnityEngine;
using System.Collections;

public class spawning : MonoBehaviour {

	public GameObject[] o;
	public float spawnMin=1f;
	public float spawnMax=2f;

	// Use this for initialization
	void Start () {
		call ();
	}
	
	// Update is called once per frame
	void call() {

		Instantiate(o[Random.Range(0,o.Length)],transform.position,Quaternion.identity);
		Invoke ("call", Random.Range (spawnMin, spawnMax));

	
	}
}
