using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public static float itemAmount;

    void Start()
    {
        itemAmount = 0;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (itemAmount < 1)
            {
                itemAmount += 0.2f;
            }
        }
    }

}
