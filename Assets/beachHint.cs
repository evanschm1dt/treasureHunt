using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class beachHint : MonoBehaviour {
	public Text hintText;
	public Transform playerPos;
	public Transform beachPos;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((playerPos.position - beachPos.position).magnitude < 15f) {
			hintText.text = "Now go east to the buoy";
		}
	}
}
