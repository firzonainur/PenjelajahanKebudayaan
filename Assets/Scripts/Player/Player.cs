using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Atribut pada player
    public float playerSpeed; //kecepatan player
    public float jumpPower; // kekuatan melompat player

    public bool isJumping; // variabel cek kondisi jump
    public bool isDied; // variabel cek kondisi jump
    private float move; // variabel posisi pindah player
    private Rigidbody2D rb; // variabel rigidbody player
    private Animator anim;//private Animator anim; //variabel animator player

    public GameObject weapon, posWeapon, effectWeapon;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // mendapatkan nilai rigidbody
        anim = GetComponent<Animator>(); // mendapatkan nilai animator

    }

    void Die()
    {
        Destroy(gameObject); // memusnahkan player
        isDied = false;
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Instantiate(weapon, posWeapon.transform.position, posWeapon.transform.rotation);
            Instantiate(effectWeapon, posWeapon.transform.position, posWeapon.transform.rotation);
            anim.SetTrigger("isAttack");
        }

        if(PlayerHealth.healthAmount < 0.1)
        {
            isDied = true;
        }

        RunAnimations();
    }

    void RunAnimations()
    {
        anim.SetFloat("isWalk", Mathf.Abs(move));
        anim.SetBool("isJump", isJumping);
        anim.SetBool("isDead", isDied);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
