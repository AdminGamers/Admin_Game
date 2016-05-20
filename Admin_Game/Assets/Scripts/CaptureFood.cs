using UnityEngine;
using System.Collections;

public class CaptureFood : MonoBehaviour {

	public static float money = 5000;


	void OnMouseDown(){
		Destroy(gameObject);
		RestaurantManager.moneyText.text = "Gastos: "+ (money-200) + " R$";

	}

}
