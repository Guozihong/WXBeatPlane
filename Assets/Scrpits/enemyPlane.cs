using UnityEngine;
using System.Collections;

public class enemyPlane : MonoBehaviour {
	public enum EnemyType{
		smallEnemy,
		midEnemy,
		bigEnemy
	}

	public EnemyType type = EnemyType.smallEnemy;
	public float speed = 2;
	public int lifeValue = 1;
	public int value = 100;

	public int dieAnimateFrame = 5;
	public Sprite[] dieSpriteArr;
	private float dieTimer = 0;
	//受伤动画
	public Sprite[] hurtSpriteArr;

	//爆炸音效
	public AudioClip boomEffect;
	private float hurtTimer = 0;

	private bool isDie = false;
	private bool isHit = false;
	private SpriteRenderer spriteRender;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		spriteRender = gameObject.GetComponent<SpriteRenderer> ();
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Bullet") {
			beHit ();
		}
	}
//	void OnCollisionEnter2D(Collision2D other)
//	{
//		print ("enemy collision");
//	}
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down * speed * Time.deltaTime);
		if (transform.position.y < -5.4f) {
			Destroy (this.gameObject);
		}
		if (isDie) {
			dieTimer += Time.deltaTime;
			int index = (int)(dieTimer / (1f / dieAnimateFrame));
			if (index + 1 > dieSpriteArr.Length) {
				die ();
			} else {
				spriteRender.sprite = dieSpriteArr [index];
			}
		}
		if (isHit) {
			hurtTimer += Time.deltaTime;
			int index = (int)(hurtTimer/(1f/dieAnimateFrame));
			if (index + 1 > hurtSpriteArr.Length) {
				isHit = false;
			} else {
				spriteRender.sprite = hurtSpriteArr[index];
			}
		}
	}

	void beHit()
	{
		if (!isDie) {
			lifeValue--;
			if (lifeValue <= 0) {
				if (type == EnemyType.bigEnemy) {
					audioSource.PlayOneShot (boomEffect);
				} else {
					audioSource.Play ();
				}
				this.isDie = true;
			} else {
				this.isHit = true;
				hurtTimer = 0;
			}
		}

	}

	void die(){
		GameObject.Destroy (gameObject);
		GameManager gameManager =  GameManager.getInstance ();
		gameManager.SendMessage ("addScore",value);
	}
}
