using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpLev1 : MonoBehaviour
{
    public GameObject pesan, icon;
    public void Aktifkan()
    {
        //pesan.SetActive(true);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pesan.SetActive(true);
            icon.SetActive(true);
            Debug.Log("kena gatot");
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pesan.SetActive(false);
            Debug.Log("kena gatot");
        }
    }

    public void destroying()
    {
        Destroy(gameObject);
    }

}
