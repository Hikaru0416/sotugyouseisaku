using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityAttack : MonoBehaviour
{

    Animator animator;
    public CapsuleCollider capsuleCollider;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //左クリックで攻撃のアニメーションを出す
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attack", true);
        }
    }

    //アニメーションイベント
    //アニメーションの開始と同時にColliderを出す
    void Attack1Start()
    {
        capsuleCollider.enabled = true;
    }

    //アニメーションイベント
    //アニメーションの終了と同時にColliderを消す
    //アニメーションを攻撃から待機へ戻す
    void Attack1End()
    {
        capsuleCollider.enabled = false;
        animator.SetBool("Attack", false);
    }
}
