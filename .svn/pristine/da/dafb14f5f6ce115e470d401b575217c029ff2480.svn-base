using UnityEngine;
using System.Collections;

public class enemyCreate : MonoBehaviour {

	public float enemy01CreateRate = 0.2f;
	public float enemy02CreateRate = 2f;
	public float enemy03CreateRate = 15f;
	//奖励物品
	public float award01CreateRate = 15f;
	public float award02CreateRate = 20f;

	public GameObject enemy01Prefab;
	public GameObject enemy02Prefab;
	public GameObject enemy03Prefab;

	public GameObject award01Prefab;
	public GameObject award02Prefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("createEnemy01",enemy01CreateRate,enemy01CreateRate);
		InvokeRepeating ("createEnemy02",enemy02CreateRate,enemy02CreateRate);
		InvokeRepeating ("createEnemy03",enemy03CreateRate,enemy03CreateRate);
		InvokeRepeating ("createAward01",award01CreateRate,award01CreateRate);
		InvokeRepeating ("createAward02",award02CreateRate,award02CreateRate);
	}
	void createEnemy01 () {
		float _x = Random.Range (-2.18f, 2.18f);
		var pos = new Vector3 (_x,transform.position.y,transform.position.z);
		GameObject.Instantiate (enemy01Prefab,pos,Quaternion.identity);
	}
	void createEnemy02 () {
		float _x = Random.Range (-2.07f, 2.07f);
		var pos = new Vector3 (_x,transform.position.y,transform.position.z);
		GameObject.Instantiate (enemy02Prefab,pos,Quaternion.identity);
	}
	void createEnemy03 () {
		float _x = Random.Range (-1.55f, 1.55f);
		var pos = new Vector3 (_x,transform.position.y,transform.position.z);
		GameObject.Instantiate (enemy03Prefab,pos,Quaternion.identity);
	}
	void createAward01 () {
		float _x = Random.Range (-2.11f, 2.11f);
		var pos = new Vector3 (_x,transform.position.y,transform.position.z);
		GameObject.Instantiate (award01Prefab,pos,Quaternion.identity);
	}
	void createAward02 () {
		float _x = Random.Range (-2.11f, 2.11f);
		var pos = new Vector3 (_x,transform.position.y,transform.position.z);
		GameObject.Instantiate (award02Prefab,pos,Quaternion.identity);
	}
}
