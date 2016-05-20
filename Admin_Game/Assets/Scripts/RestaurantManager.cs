using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RestaurantManager : MonoBehaviour {

	public static float money;
	public Text moneyText;

	// Use this for initialization
void Start(){
		money = 5000;
		moneyText = GameObject.Find("TextValue").GetComponent<Text>();
		moneyText.text = "Gastos: "+ money + "R$";
	}

	// Update is called once per frame
	void Update () {

	}
}
