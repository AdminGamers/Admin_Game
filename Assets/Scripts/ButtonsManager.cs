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
					ValuesManager.fCarrot.text = "";
				  ValuesManager.fOnion.text = "";
				  ValuesManager.fPotato.text = "";
				  ValuesManager.fBanana.text = "";
				  ValuesManager.fFruits.text = "";
				  ValuesManager.fVegetables.text = "";
				  ValuesManager.fBeans.text = "";
				  ValuesManager.fChocolate.text = "";
				  ValuesManager.fBarbecue.text = "";
				  ValuesManager.fMilk.text = "";
				  ValuesManager.fCondensedMilk.text = "";
				  ValuesManager.fSyrup.text = "";
				  ValuesManager.fEggs.text = "";
				  ValuesManager.fBacon.text = "";
				  ValuesManager.fBread.text = "";
				  ValuesManager.fRice.text = "";
					ValuesManager.fFlour.text = "";
				  ValuesManager.fPig.text = "";
				  ValuesManager.fChicken.text = "";
        }
        Debug.Log("Mudou de Scene");
		//Application.LoadLevel("");
	}

}
