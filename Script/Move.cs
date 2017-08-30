using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.W))
		transform.Translate(Vector3.up * -1 * Time.deltaTime * speed);

	if(Input.GetKey(KeyCode.S))
		transform.Translate(Vector3.up * Time.deltaTime * speed);
  
 



	}
}
