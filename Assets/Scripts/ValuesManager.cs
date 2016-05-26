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
	 	fOnion = GameObject.Find("OnionField").GetComponent<InputField>();
	 	fPotato = GameObject.Find("PotatoField").GetComponent<InputField>();
	 	fBanana = GameObject.Find("BananaField").GetComponent<InputField>();
	 	fFruits = GameObject.Find("FruitsField").GetComponent<InputField>();
	 	fVegetables = GameObject.Find("VegetablesField").GetComponent<InputField>();
	 	fBeans = GameObject.Find("BeansField").GetComponent<InputField>();
		fChocolate = GameObject.Find("ChocolateField").GetComponent<InputField>();
	 	fBarbecue = GameObject.Find("BarbecueField").GetComponent<InputField>();
	 	fMilk = GameObject.Find("MilkField").GetComponent<InputField>();
	 	fCondensedMilk = GameObject.Find("CondensedMilkField").GetComponent<InputField>();
	 	fSyrup = GameObject.Find("SyrupField").GetComponent<InputField>();
	 	fEggs = GameObject.Find("EggField").GetComponent<InputField>();
	 	fBacon = GameObject.Find("BaconField").GetComponent<InputField>();
	 	fBread = GameObject.Find("BreadField").GetComponent<InputField>();
	 	fRice = GameObject.Find("RiceField").GetComponent<InputField>();
	 	fFlour = GameObject.Find("FlourField").GetComponent<InputField>();
	 	fPig = GameObject.Find("PigField").GetComponent<InputField>();
	 	fChicken = GameObject.Find("ChickenField").GetComponent<InputField>();
	}

}
