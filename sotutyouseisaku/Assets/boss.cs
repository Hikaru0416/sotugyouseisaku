using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class boss : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent Boss;
    Animator animator;
    private int Bosshp = 10;
    public GameObject star;
    Slider _slider;
    int playerflag = 0;
    public static int hpflag2 = 0;

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

    void attackend()
    {
        hpflag2 = 1;
        animator.SetBool("is_attack", false);

    }
    void hp()
    {
        hpflag2 = 0;
    }
    void damageend()
    {
        animator.SetBool("is_damage", false);
    }
    void deathend()
    {
        Destroy(this.gameObject);
        Instantiate<GameObject>(star, transform.position + Vector3.up * 20, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Boss = gameObject.GetComponent<NavMeshAgent>();
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float dis = (target.transform.position - Boss.transform.position).sqrMagnitude;
        if (dis < 20.0f && dis > 3.0f)
        {
            //追跡
            Boss.destination = target.transform.position;
            animator.SetBool("is_run", true);
        }
        else if (dis < 3.0f && dis > 0.0f)
        {

        }
        else if (dis > 20.0f)
        {
            animator.SetBool("is_run", false);
        }
        //unityちゃんが攻撃したとき
        if (Input.GetMouseButtonUp(0) && playerflag == 1)
        {
            Bosshp -= 1;
            animator.SetBool("is_damage", true);
        }
        if (Bosshp <= 0)
        {
            animator.SetBool("is_death", true);
        }

        // HPゲージに値を設定
        _slider.value = Bosshp;
    }

    public static int gethp()
    {
        return hpflag2;
    }
}
