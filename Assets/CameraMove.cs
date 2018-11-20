using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {



	// Update is called once per frame
	void Update () {
	
		Camera.main.transform.Translate( 0, 0.1f, 0);

	}
}
