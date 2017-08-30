using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {
public Button boton;	

void Start(){

Button btn = boton.GetComponent<Button>();
btn.onClick.AddListener(TaskOnClick);

}








public void TaskOnClick(){
 Debug.Log("start");
 Application.LoadLevel(1);
}


}
