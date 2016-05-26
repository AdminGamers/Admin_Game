using UnityEngine;
using System.Collections;
using System;
using System.IO;
using UnityEngine.UI;

public class ValuesManager : MonoBehaviour {

	public static InputField fCarrot;
	public static InputField fOnion;
	public static InputField fPotato;
	public static InputField fBanana;
	public static InputField fFruits;
	public static InputField fVegetables;
	public static InputField fBeans;
	public static InputField fChocolate;
	public static InputField fBarbecue;
	public static InputField fMilk;
	public static InputField fCondensedMilk;
	public static InputField fSyrup;
	public static InputField fEggs;
	public static InputField fBacon;
	public static InputField fBread;
	public static InputField fRice;
	public static InputField fFlour;
	public static InputField fPig;
	public static InputField fChicken;

	// Use this for initialization
	void Start () {
		fCarrot = GameObject.Find("CarrotField").GetComponent<InputField>();
		fCarrot.characterLimit = 3;

	 	fOnion = GameObject.Find("OnionField").GetComponent<InputField>();
		fOnion.characterLimit = 3;

	 	fPotato = GameObject.Find("PotatoField").GetComponent<InputField>();
		fPotato.characterLimit = 3;

	 	fBanana = GameObject.Find("BananaField").GetComponent<InputField>();
		fBanana.characterLimit = 3;

	 	fFruits = GameObject.Find("FruitsField").GetComponent<InputField>();
		fFruits.characterLimit = 3;

	 	fVegetables = GameObject.Find("VegetablesField").GetComponent<InputField>();
		fVegetables.characterLimit = 3;

	 	fBeans = GameObject.Find("BeansField").GetComponent<InputField>();
		fBeans.characterLimit = 3;

		fChocolate = GameObject.Find("ChocolateField").GetComponent<InputField>();
		fChocolate.characterLimit = 3;

	 	fBarbecue = GameObject.Find("BarbecueField").GetComponent<InputField>();
		fBarbecue.characterLimit = 3;

	 	fMilk = GameObject.Find("MilkField").GetComponent<InputField>();
		fMilk.characterLimit = 3;

	 	fCondensedMilk = GameObject.Find("CondensedMilkField").GetComponent<InputField>();
		fCondensedMilk.characterLimit = 3;

	 	fSyrup = GameObject.Find("SyrupField").GetComponent<InputField>();
		fSyrup.characterLimit = 3;

	 	fEggs = GameObject.Find("EggField").GetComponent<InputField>();
		fEggs.characterLimit = 3;

	 	fBacon = GameObject.Find("BaconField").GetComponent<InputField>();
		fBacon.characterLimit = 3;

	 	fBread = GameObject.Find("BreadField").GetComponent<InputField>();
		fBread.characterLimit = 3;

	 	fRice = GameObject.Find("RiceField").GetComponent<InputField>();
		fRice.characterLimit = 3;

	 	fFlour = GameObject.Find("FlourField").GetComponent<InputField>();
		fFlour.characterLimit = 3;

	 	fPig = GameObject.Find("PigField").GetComponent<InputField>();
		fPig.characterLimit = 3;

	 	fChicken = GameObject.Find("ChickenField").GetComponent<InputField>();
		fChicken.characterLimit = 3;
	}

}
