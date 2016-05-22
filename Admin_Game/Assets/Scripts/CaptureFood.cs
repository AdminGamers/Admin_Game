using UnityEngine;
using System.Collections;

public class CaptureFood : MonoBehaviour {

	public static float money = 5000;


	void OnMouseDown(){
		Destroy(gameObject);
        switch (gameObject.tag){ 
            case "Carrot":
                RestaurantManager.moneyText.text = "Gastos: " + (money - 200) + " R$";
                break;
            default:
                RestaurantManager.moneyText.text = "Gastos: " + (money - 0) + " R$";
                break;
        }
	}

}
