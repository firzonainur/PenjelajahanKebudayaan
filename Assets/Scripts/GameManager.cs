using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
	public static bool GameIsComplete;

	public GameObject gameCompleteUI;

	void Start()
	{
		GameIsComplete = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (GameIsComplete)
			return;

		if (Items.itemAmount > 0.99)
		{
			CompleteGame();
        }
 
	}

	void CompleteGame()
	{
		GameIsComplete = true;
		gameCompleteUI.SetActive(true);

	}

	public void WinLevel()
    {
		GameIsComplete = true;
	}

}

