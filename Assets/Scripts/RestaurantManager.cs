using UnityEngine;
using System.Collections;
using System;
using System.IO;
using UnityEngine.UI;

public class RestaurantManager : MonoBehaviour {

	public Text moneyText;
	public Text listText;

	// Use this for initialization
void Start(){
		moneyText = GameObject.Find("TextValue").GetComponent<Text>();
		listText = GameObject.Find("ListValue").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		moneyText.text = "Valor total: " + CaptureFood.money + " R$";
		listText.text = "Compras:\n\n\n " + CaptureFood.qCarrot + " Cenouras\t\t\t "
																	+ CaptureFood.qOnion + " Cebolas\n "
																  + CaptureFood.qPotato + " Batatas\t\t\t\t "
																  + CaptureFood.qBanana + " Bananas\n "
																  + CaptureFood.qFruits + " Frutas\t\t\t\t\t "
																  + CaptureFood.qVegetables + " Vegetais\n "
																  + CaptureFood.qBeans + " Feijões\t\t\t\t "
																  + CaptureFood.qChocolate + " Chocolates\n "
																  + CaptureFood.qBarbecue + " Barbecue\t\t\t "
																  + CaptureFood.qMilk + " Leites\n "
																  + CaptureFood.qCondensedMilk + " Leite Condensado\t "
																  + CaptureFood.qSyrup + " Caldas\n "
																  + CaptureFood.qEggs + " Ovos\t\t\t\t\t "
																  + CaptureFood.qBacon + " Bacon\n "
																  + CaptureFood.qBread + " Pães\t\t\t\t\t "
																  + CaptureFood.qRice + " Arroz\n "
																  + CaptureFood.qFlour + " Farinhas\t\t\t\t "
																  + CaptureFood.qPig + " Porcos\n "
																  + CaptureFood.qChicken + " Frangos\n ";
	}

}
