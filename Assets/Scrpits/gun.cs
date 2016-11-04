using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {

	public GameObject bulletPrefab;
	public float rate = 0.5f;
	// Use this for initialization
	void Start () {
	}
	void fire()
	{
		GameObject.Instantiate (bulletPrefab,transform.position,Quaternion.identity);
	}

	public void stopFire(){
		CancelInvoke ("fire");
	}

	public void openFire(){
		InvokeRepeating ("fire",rate,rate);
	}

}
