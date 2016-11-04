using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager _instance;
	private Text scoreText;
	// Use this for initialization
	private int score = 0;
	void Awake (){
		_instance = this;	
	}

	void Start () {
		scoreText = GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void addScore(int score){
		this.score += score;
		scoreText.text = "Score:"+this.score.ToString();
	}

	public static GameManager getInstance(){
		return _instance;
	}
}
