using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class test : MonoBehaviour {
Text text;
	// Use this for initialization
	void Start () {
  Text text = GetComponent<Text>();
  text.text = "hello";
	text.fontSize = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
