using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsLev1 : MonoBehaviour
{
    public int hitung;

    private void Start()
    {
       
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            hitung = PlayerPrefs.GetInt("akumulasiCoin1") + 1;
            PlayerPrefs.SetInt("akumulasiCoin1", hitung);
            Destroy(gameObject);
            //Debug.Log(hitung);
        }
        }
    }
