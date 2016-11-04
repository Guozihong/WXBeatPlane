using UnityEngine;
using System.Collections;

public class mainRole : MonoBehaviour {

//	enum AwardType {
//		doubleGun,
//		clearScreen,
//	}

	public int frame = 5;
	public bool isRunAnimate = true;
	public Sprite[] sprites;
	public gun topGun;
	public gun leftGun;
	public gun rightGun;


	private SpriteRenderer spriteRenderer;
	private Vector3 lastPos = Vector3.zero;
	private Camera mainCamera;
	private float doubleGunTimer = 0;
	private float doubleGunTime = 10;
	// Use this for initialization
	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		mainCamera = Camera.main;
		topGun.openFire ();
	}
	// Update is called once per frame
	void Update () {
		if (isRunAnimate) {
			float oneFrameTime = 1f / frame;
			float curFrame = Time.time / oneFrameTime;
			int curFrameIndex = (int)curFrame % sprites.Length;
			spriteRenderer.sprite = sprites [curFrameIndex];			
		}
		if (Input.GetMouseButton(0)) {
			var curMousePos = mainCamera.ScreenToWorldPoint (Input.mousePosition);
			if (lastPos != Vector3.zero) {
				//得到两次位置的偏移
				var offset = curMousePos - lastPos;
				//判断偏移后位置是否超出屏幕，超出则不进行移动
				var pos = offset + transform.position;
				if (pos.x < 2.25f && pos.x > -2.25f && pos.y > -3.5f && pos.y < 3.37f) {
					transform.Translate (offset);
				}
			}
			//上一次位置等于现在的位置
			lastPos = curMousePos;
		}
		if (Input.GetMouseButtonUp (0)) {
			//抬起后对上一次的值进行置0
			lastPos = Vector3.zero;
		}
		//双枪倒计时
		if (doubleGunTimer > 0) {
			doubleGunTimer -= Time.deltaTime;
			if (doubleGunTimer <= 0) {
				exchangeGun ();
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Award") {
			award awardScript = other.gameObject.GetComponent<award> ();
			if (awardScript.getType () == award.AwardType.doubleGun) {
				doubleGunTimer = doubleGunTime;
				exchangeGun ();
			}
		}
	}
	void exchangeGun(){
		if (doubleGunTimer > 0) {
			topGun.stopFire ();
			leftGun.openFire ();
			rightGun.openFire ();
		} else {
			topGun.openFire ();
			leftGun.stopFire ();
			rightGun.stopFire ();
		}

	}
}
