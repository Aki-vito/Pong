using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Wall2score : MonoBehaviour {
	Text Text2;
	public static  int count2;
	public float seconds;
	public  static string score2;
	public Font normalFont;
	void Start(){
		Instantiate(Text2);

		count2 = 0;

	} 
	void OnGUI() {

		GUIStyle myStyle = new GUIStyle(GUI.skin.label);
		myStyle.fontSize = 28;	
		myStyle.font = normalFont;	
		GUI.Label(new Rect(300, 100, 1600, 1600),score2,myStyle );

	}

	void OnCollisionEnter2D(Collision2D colr2)

	{
		if(colr2.gameObject.name == "Ball"){

			Debug.Log("P1 scores");

			count2 += 1;
			score2 = count2.ToString();	
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);

		}

	}






}
