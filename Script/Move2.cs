using UnityEngine;
using System.Collections;

public class Move2 : MonoBehaviour {
 
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	if(Input.GetKey(KeyCode.UpArrow))
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	if(Input.GetKey(KeyCode.DownArrow))
		transform.Translate(Vector3.up * -1  * Time.deltaTime * speed);
	}
}
