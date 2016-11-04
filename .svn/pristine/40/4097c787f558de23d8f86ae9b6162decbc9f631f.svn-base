using UnityEngine;
using System.Collections;

public class award : MonoBehaviour {

	public enum AwardType {
		doubleGun,
		clearScreen,
	}

	public float speed = 2;
	public AwardType type = AwardType.doubleGun; //1 双枪 2 清屏
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
		if (transform.position.y < -4.8) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			GameObject.Destroy (this.gameObject);
		}
	}
	public AwardType getType(){
		return this.type;
	}
}
