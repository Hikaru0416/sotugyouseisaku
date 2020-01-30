using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityAttack : MonoBehaviour
{

   private Animator animator;


    //武器のコライダー
    private Collider WeaponCollider;
    

    void Start()
    {
        animator = GetComponent<Animator>();
        //武器のコライダーを取得
        WeaponCollider = GameObject.Find("WMU_02_Weapon_L").GetComponent<BoxCollider>();
    }

    void Update()
    {
        //左クリックで攻撃のアニメーションを出す
        if ((Input.GetMouseButtonDown(0))&& !animator.GetBool("Attack"))
        {
            animator.SetBool("Attack", true);

            //武器コライダーをオンにする
            WeaponCollider.enabled = true;

            //一定時間後にコライダーの機能をオフにする
            Invoke("ColliderReset",1.2f);
        }
    }
    private void ColliderReset()
    {
        WeaponCollider.enabled = false;
      ;
    }
    //アニメーションイベント
    //アニメーションの終了と同時にColliderを消す
    //アニメーションを攻撃から待機へ戻す
    void Attack1End()
    {
        animator.SetBool("Attack", false);
    }
}
