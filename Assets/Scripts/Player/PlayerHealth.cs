using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static float healthAmount;

    void Start()
    {
        healthAmount = 1;
    }

    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            if (healthAmount > 0)
            {
                healthAmount -= 0.25f;
            }
            else
            {
                healthAmount = 0f;
            }
        }
    }
}
