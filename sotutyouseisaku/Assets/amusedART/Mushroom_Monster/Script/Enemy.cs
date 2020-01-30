using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent enemy;
    Animation anim;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
        enemy = gameObject.GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        float dis = (target.transform.position - enemy.transform.position).sqrMagnitude;
        if (dis < 30.0f && dis > 6.0f)
        {
            //追跡
            enemy.destination = target.transform.position;
            Debug.Log("追跡中");
            anim.Play("Run");
        }
        else if (dis < 6.0f && dis > 0.0f)
        {
            //攻撃
            Debug.Log("攻撃");
            anim.Play("Attack");
        }
        else if (dis > 30.0f)
        {
            //徘徊中
            Debug.Log("徘徊中");
            anim.Play("Idle");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //unityちゃんに攻撃されたとき
            Debug.Log("死亡");
            
            //Destroy(gameObject);
        }
    }
}