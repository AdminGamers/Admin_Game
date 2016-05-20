using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RestaurantManager : MonoBehaviour {

	public static Text moneyText;

	// Use this for initialization
void Start(){
		moneyText = GameObject.Find("TextValue").GetComponent<Text>();
		moneyText.text = "Gastos: "+ CaptureFood.money + "R$";
	}

	// Update is called once per frame
	void Update () {
		
	}
}
