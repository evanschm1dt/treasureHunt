using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class buoyHint : MonoBehaviour {
	public Text hintText;
	public Transform playerPos;
	public Transform buoyPos;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((playerPos.position - buoyPos.position).magnitude < 15f) {
			hintText.text = "Sail north until you find a submarine";
		}
	}
}
