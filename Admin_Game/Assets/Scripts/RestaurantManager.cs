using UnityEngine;
using System.Collections;
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
		listText.text = "Você comprou:\n " + CaptureFood.qCarrot + " Cenouras\n "
		 																	 + CaptureFood.qOnion + " Bacons\n "
																			 + CaptureFood.qPotato + " Batatas\n "
																			 + CaptureFood.qBanana + " Bananas\n "
																			 + CaptureFood.qFruits + " Cestas de frutas\n "
																			 + CaptureFood.qVegetables + " Cestas de vegetais\n "
																			 + CaptureFood.qBeans + " Pacotes de feijão\n "
																			 + CaptureFood.qChocolate + " Chocolates\n "
																			 + CaptureFood.qBarbecue + " Barbecue\n "
																			 + CaptureFood.qMilk + " Litros de Leite\n "
																			 + CaptureFood.qCondensedMilk + " Leite Condensado\n "
																			 + CaptureFood.qSyrup + " Caldas\n "
																			 + CaptureFood.qEggs + " Ovos\n "
																			 + CaptureFood.qBacon + " Bacon\n "
																			 + CaptureFood.qBread + " Pães\n "
																			 + CaptureFood.qRice + " Arroz\n "
																			 + CaptureFood.qFlour + " Sacos de farinha\n "
																			 + CaptureFood.qPig + " Quilos de porco\n "
																			 + CaptureFood.qChicken + " Frangos\n ";
	}

}
