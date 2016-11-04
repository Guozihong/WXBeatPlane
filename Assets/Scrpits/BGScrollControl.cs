using UnityEngine;
using System.Collections;

public class BGScrollControl : MonoBehaviour {

	public float speed = 2;
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
		if (transform.position.y <= -8.2f) {
			transform.position = new Vector3(transform.position.x,8.2f,transform.position.z);
		}
	}
}
