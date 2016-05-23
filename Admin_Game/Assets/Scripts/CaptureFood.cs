using UnityEngine;
using System.Collections;

public class CaptureFood : MonoBehaviour {

	public static float money=5000;
	public static int qCarrot = 0;
	public static int qOnion = 0;
	public static int qPotato = 0;
	public static int qBanana = 0;
	public static int qFruits = 0;
	public static int qVegetables = 0;
	public static int qBeans = 0;
	public static int qChocolate = 0;
	public static int qBarbecue = 0;
	public static int qMilk = 0;
	public static int qCondensedMilk = 0;
	public static int qSyrup = 0;
	public static int qEggs = 0;
	public static int qBacon = 0;
	public static int qBread = 0;
	public static int qRice = 0;
	public static int qFlour = 0;
	public static int qPig = 0;
	public static int qChicken = 0;


	void OnMouseDown(){
		Destroy(gameObject);
        switch (gameObject.tag){
            case "Carrot":
							 	money -= 200;
								qCarrot += 1;
                break;

            case "Bacon":
								money -= 800;
								qBacon += 1;
                break;
        }
	}

}
