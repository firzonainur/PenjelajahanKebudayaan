using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float stoppingDistance;
    public GameObject player;
    public GameObject enemy;
    public Animator enemyAnim;


    // Start is called before the first frame update
    void Start()
    {
        //menemukan objek dan posisi
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < enemy.transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            enemyAnim.SetBool("isEnemyAttack", false);
            enemyAnim.SetBool("isEnemyWalk", false);
        }
        else if (Vector2.Distance(transform.position, target.position) < stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            enemyAnim.SetBool("isEnemyAttack", true);
            enemyAnim.SetBool("isEnemyWalk", true);
        }
    }

}
