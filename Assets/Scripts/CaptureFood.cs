using UnityEngine;
using System.Collections;
using System;
using System.IO;
using UnityEngine.UI;

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


	void Update(){
		try{
			qCarrot = int.Parse(ValuesManager.fCarrot.text);
		}catch(Exception e){
			qCarrot = 0;
		}

		try{
			qOnion = int.Parse(ValuesManager.fOnion.text);
		}catch(Exception e){
			qOnion = 0;
		}

		try{
			qPotato = int.Parse(ValuesManager.fPotato.text);
		}catch(Exception e){
			qPotato = 0;
		}

		try{
			qBanana = int.Parse(ValuesManager.fBanana.text);
		}catch(Exception e){
			qBanana = 0;
		}

		try{
			qFruits = int.Parse(ValuesManager.fFruits.text);
		}catch(Exception e){
			qFruits = 0;
		}

		try{
			qVegetables = int.Parse(ValuesManager.fVegetables.text);
		}catch(Exception e){
			qVegetables = 0;
		}

		try{
			qBeans = int.Parse(ValuesManager.fBeans.text);
		}catch(Exception e){
			qBeans = 0;
		}

		try{
			qChocolate = int.Parse(ValuesManager.fChocolate.text);
		}catch(Exception e){
			qChocolate = 0;
		}

		try{
			qBarbecue = int.Parse(ValuesManager.fBarbecue.text);
		}catch(Exception e){
			qBarbecue = 0;
		}

		try{
			qMilk = int.Parse(ValuesManager.fMilk.text);
		}catch(Exception e){
			qMilk = 0;
		}

		try{
			qCondensedMilk = int.Parse(ValuesManager.fCondensedMilk.text);
		}catch(Exception e){
			qCondensedMilk = 0;
		}

		try{
			qSyrup = int.Parse(ValuesManager.fSyrup.text);
		}catch(Exception e){
			qSyrup = 0;
		}

		try{
			qEggs = int.Parse(ValuesManager.fEggs.text);
		}catch(Exception e){
			qEggs = 0;
		}

		try{
			qBacon = int.Parse(ValuesManager.fBacon.text);
		}catch(Exception e){
			qBacon = 0;
		}

		try{
			qBread = int.Parse(ValuesManager.fBread.text);
		}catch(Exception e){
			qBread = 0;
		}

		try{
			qRice = int.Parse(ValuesManager.fRice.text);
		}catch(Exception e){
			qRice = 0;
		}

		try{
			qFlour = int.Parse(ValuesManager.fFlour.text);
		}catch(Exception e){
			qFlour = 0;
		}

		try{
			qPig = int.Parse(ValuesManager.fPig.text);
		}catch(Exception e){
			qPig = 0;
		}

		try{
			qChicken = int.Parse(ValuesManager.fChicken.text);
		}catch(Exception e){
			qChicken = 0;
		}

	}
}
