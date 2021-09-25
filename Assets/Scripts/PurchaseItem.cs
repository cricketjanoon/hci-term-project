using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseItem : MonoBehaviour {


	public GameObject musicPlayer;
	AudioSource audioSource;

	public Text userCoinCount;
	public Text userGemCount;
	public Text userDollarCount;

	int userDollars, userCoins, userGems;


	public bool isCoin;
	public Text numberText;
	public Text priceText;

	public Image coinImage;
	public Image gemImage;
	
	public int number;
	public int price;



	// Use this for initialization
	void Start () {
		numberText.text = number.ToString();
		priceText.text = price.ToString();

		if (isCoin)
		{
			coinImage.enabled = true;
			gemImage.enabled = false;
		}
		else if (!isCoin)
		{
			gemImage.enabled = true;
			coinImage.enabled = false;
		}

		audioSource = musicPlayer.GetComponent<AudioSource>();
		
			
	}

	private void Update()
	{
		userDollars = int.Parse(userDollarCount.text);
		userCoins = int.Parse(userCoinCount.text);
		userGems = int.Parse(userGemCount.text);
	}


	public void PuchaseSelectedItem()
	{
		
		if (price > userDollars)
			return;


		audioSource.Play();

		userDollars -= price;

		if (isCoin)
			userCoins += number;
		else if (!isCoin)
		{
			userGems += number;
		}


		userCoinCount.text = userCoins.ToString();
		userDollarCount.text = userDollars.ToString();
		userGemCount.text = userGems.ToString();

		this.gameObject.SetActive(false);

	}

}
