using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    private Rigidbody rb2d;

    public Animator enemyAnim;

    public static float healthAmount;

    public GameObject posWeapon, hitWeapon;



    Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        healthAmount = 1;
        localScale = transform.localScale;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Keris"))
        {
            if (healthAmount > 0)
            {
                healthAmount -= 0.1f;
            }
            else
            {
                healthAmount = 0f;
            }

            enemyAnim.SetBool("isEnemyAttacked", true);
            Instantiate(hitWeapon, posWeapon.transform.position, posWeapon.transform.rotation);

            if (healthAmount < 0.1f)
            {
                enemyAnim.SetBool("isEnemyDie", true);
            }
        }
    }

    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Keris"))
        {
            enemyAnim.SetBool("isEnemyAttacked", false);
        }
    }

    void EnemyDie()
    {
        Destroy(gameObject);
        Debug.Log("musuh mati");
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

    }

}
