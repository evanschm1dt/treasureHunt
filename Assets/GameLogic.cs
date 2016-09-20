using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	bool didPlayerWin = false;
	public Text winStatement;
	public Transform playerPos;
	public Transform treasurePos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (didPlayerWin) {
			winStatement.text = "YOU WIN";
		}
		else if ((playerPos.position - treasurePos.position).magnitude <5f){
			winStatement.text = "Press [SPACE] to get the treasure";
			if (Input.GetKey(KeyCode.Space)){
				didPlayerWin = true;
		}
	}
}
}