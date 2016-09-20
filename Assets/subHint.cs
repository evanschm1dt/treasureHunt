using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class subHint : MonoBehaviour {
	public Text hintText;
	public Transform playerPos;
	public Transform subPos;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((playerPos.position - subPos.position).magnitude < 15f) {
			hintText.text = "Sail east to claim your treasure";
		}
	}
}
