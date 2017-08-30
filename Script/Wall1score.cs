using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Wall1score : MonoBehaviour {
 public Text theText; 
 public Font normalFont;
  Text Text;
 public Font hoverFont;
	public static  int count;
	public  static string score;

	void Start(){
		theText.font = hoverFont;
 Instantiate(Text);
  FontStyle fontStyle = new FontStyle();
  
   
 	 count = 0;
  
	} 
	void OnGUI() {
    GUIStyle myStyle = new GUIStyle(GUI.skin.label);
	  myStyle.fontSize = 28;
	  myStyle.font = hoverFont;	
		GUI.Label(new Rect(900, 100, 1200, 1200),score,myStyle );
   


		
	 	
	 
	}

	void OnCollisionEnter2D(Collision2D colr)

	{
		if(colr.gameObject.name == "Ball"){

			Debug.Log("P2 scores");
			count += 1;
      score = count.ToString();	

  SceneManager.LoadScene(SceneManager.GetActiveScene().name);	






}}


 



}
