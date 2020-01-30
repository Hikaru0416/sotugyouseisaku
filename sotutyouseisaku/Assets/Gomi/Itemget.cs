using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemget : MonoBehaviour
{
    //【追加】SE
    public AudioClip sound01;

    //トリガーとの接触時に呼ばれる
    void OnCollisionEnter(Collision col)
    {
        //接触対象はなんのタグ？（プレイヤー）
        if (col.gameObject.CompareTag("Player"))
        {
            //【追加】SEを再生
            AudioSource.PlayClipAtPoint(sound01, transform.position);

            //このコンポーネントを持つ破壊する
            Destroy(gameObject);
        }
    }
}
