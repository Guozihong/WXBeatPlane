using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
	public float speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			GameObject.Destroy (this.gameObject);
		}
	}

//	void OnCollisionEnter2D(Collision2D other)
//	{
//		print ("bullet collision");
//	}
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up*speed*Time.deltaTime);
		if (transform.position.y > 4.3f)
			Destroy (this.gameObject);
	}
}
