using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel3 : MonoBehaviour
{
	public int levelToUnlock = 4;
	public void Continue()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock);
	}
}
