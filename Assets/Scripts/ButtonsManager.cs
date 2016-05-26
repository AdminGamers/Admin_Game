using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
    public double Price(){
       double price = CaptureFood.qCarrot * 1.50 +
										  CaptureFood.qOnion * 2.0 +
							        CaptureFood.qPotato * 2.0 +
							        CaptureFood.qBanana * 2.0 +
							        CaptureFood.qFruits * 4.0 +
							        CaptureFood.qVegetables * 5.50 +
							        CaptureFood.qBeans * 4.50 +
							        CaptureFood.qChocolate * 5.0 +
							        CaptureFood.qBarbecue * 3.50 +
							        CaptureFood.qMilk * 4.0 +
							        CaptureFood.qCondensedMilk * 4.5 +
							        CaptureFood.qSyrup * 9.0 +
							        CaptureFood.qEggs * 3.0 +
							        CaptureFood.qBacon * 3.0 +
							        CaptureFood.qBread * 3.0 +
							        CaptureFood.qRice * 5.0 +
							        CaptureFood.qFlour * 4.0 +
							        CaptureFood.qPig * 7.0 +
							        CaptureFood.qChicken * 6.5;
        return price;
    }
	public void Bt_Buy(){
        if (CaptureFood.money > Price()){
        	CaptureFood.money = CaptureFood.money - Price();
					ValuesManager.fCarrot.text = "";
        }
        Debug.Log("Mudou de Scene");
		//Application.LoadLevel("");
	}

}
