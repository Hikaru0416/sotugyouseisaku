using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Goblin: MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent goblin;
    public int goblin_hp = 3;
    Animator animator;
    public float speed = 1f;
    public float rotationspeed = 1f;
    public float posrange = 10f;
    private Vector3 targetpos;
    private float changetarget = 30f;
    public float targetdistance;
    public static int hpflag = 0;
    int playerflag = 0;
    int flag = 0;

    Vector3 GetRandomPosition(Vector3 currentpos)
    {
        return new Vector3(Random.Range(-posrange + currentpos.x, posrange + currentpos.x), 0, Random.Range(-posrange + currentpos.z, posrange + currentpos.z));
    }

    void haikai()
    {
        if (targetdistance < changetarget) targetpos = GetRandomPosition(transform.position);
        Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("is_run", false);
            animator.SetBool("is_attack", true);
            playerflag = 1;
        }
        else
        {
            playerflag = 0;
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        targetpos = GetRandomPosition(transform.position);
        animator = GetComponent<Animator>();
        goblin = gameObject.GetComponent<NavMeshAgent>();
        
    }

    void attackend()
    {
        hpflag = 1;
        Debug.Log(hpflag);
        animator.SetBool("is_attack", false);
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
        targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
        float dis = (target.transform.position - goblin.transform.position).sqrMagnitude;
        if (dis < 20.0f && dis > 3.0f)
        {
            //追跡
            goblin.destination = target.transform.position;
            animator.SetBool("is_run", true);
        }
        else if (dis < 3.0f && dis > 0.0f)
        {
            
        }
        else if (dis > 20.0f)
        {
            //徘徊
            haikai();
            animator.SetBool("is_run", false);
        }
        //unityちゃんが攻撃したとき
        if (Input.GetMouseButtonUp(0) && playerflag == 1)
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
