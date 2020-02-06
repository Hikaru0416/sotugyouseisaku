using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    public static int vicflag = 0;
    Animator animator;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "item")
        {
            animator.SetBool("is_victory", true);
        }
    }

    void vicend()
    {
        vicflag = 1;
    }

    void vicfinal()
    {
        vicflag = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getvic()
    {
        return vicflag;
    }
}
