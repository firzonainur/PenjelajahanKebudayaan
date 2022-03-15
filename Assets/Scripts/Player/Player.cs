using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Atribut pada player
    public float playerSpeed; //kecepatan player
    public float jumpPower; // kekuatan melompat player

    public bool isJumping; // variabel cek kondisi jump
    private float move; // variabel posisi pindah player
    private Rigidbody2D rb; // variabel rigidbody player
    //private Animator anim; //variabel animator player

    //public GameObject keris, pos_keris, efek_keris;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // mendapatkan nilai rigidbody
        //anim = GetComponent<Animator>(); // mendapatkan nilai animator

    }

    void Die()
    {
        Destroy(gameObject); // memusnahkan player
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal"); //isi variabel move denngan inputan

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y); // membuat objek

        //untuk menghadap kanan dan kiri
        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown("space") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpPower));
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

}
