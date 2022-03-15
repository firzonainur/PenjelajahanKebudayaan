using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel2 : MonoBehaviour
{
	public int levelToUnlock = 3;
	public void Continue()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock);
	}
}
