using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startHint : MonoBehaviour {
	public Text hintText;
	public Transform playerPos;
	public Transform startPos;
	public Transform beachPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((playerPos.position - startPos.position).magnitude < 10f) {
			hintText.text = "Head south to the sandy island";
		}
		if ((playerPos.position - beachPos.position).magnitude < 10f) {
			hintText.text = "Now go east to the buoy";
		}
	}
}
