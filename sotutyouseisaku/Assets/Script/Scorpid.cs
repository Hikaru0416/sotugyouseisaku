using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Scorpid : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent scorpid;
    public int goblin_hp = 3;
    Animator animator;

    private static int hpflag = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("is_run", false);
            animator.SetBool("is_attack", true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        scorpid = gameObject.GetComponent<NavMeshAgent>();

    }

    void attackend()
    {
        animator.SetBool("is_attack", false);
        hpflag = 1;

    }
    void hp()
    {
        hpflag = 0;
    }
    void damageend()
    {
        goblin_hp -= 1;
        animator.SetBool("is_damage", false);
    }
    void deathend()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        float dis = (target.transform.position - scorpid.transform.position).sqrMagnitude;
        if (dis < 20.0f && dis > 3.0f)
        {
            //追跡
            scorpid.destination = target.transform.position;
            animator.SetBool("is_run", true);
        }
        else if (dis < 3.0f && dis > 0.0f)
        {

        }
        else if (dis > 20.0f)
        {
            //徘徊
            animator.SetBool("is_run", false);
        }
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("is_damage", true);
        }
        if (goblin_hp <= 0)
        {
            animator.SetBool("is_death", true);
        }

    }
    public static int gethp()
    {
        return hpflag;
    }
}

