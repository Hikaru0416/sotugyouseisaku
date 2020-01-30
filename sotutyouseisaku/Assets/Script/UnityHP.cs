using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityHP: MonoBehaviour
{
    private int hp = 3;
    public int enemyflag = 0;
    int hpflag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyflag = 1;
        }
        else
        {
            enemyflag = 0;
        }

    }

        // Update is called once per frame
        void Update()
    {
        hpflag = Goblin.gethp();

        if (hpflag == 1 && enemyflag == 1)
        {
            hp -= 1;
            Debug.Log("ダメージ");
        }

        if (hp <= 0)
        {
            Debug.Log("ゲームオーバー");
        }
    }
}
