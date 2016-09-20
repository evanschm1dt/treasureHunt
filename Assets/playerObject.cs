using UnityEngine;
using System.Collections;

public class playerObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0, 0, 20) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 90, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -20) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, -90, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (20, 0, 0) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 180, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-20, 0, 0) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, -180, 0);
		}
		Camera.main.transform.position = transform.position + new Vector3 (0, 15, 0);
	}
}
