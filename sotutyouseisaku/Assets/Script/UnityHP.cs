using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnityHP: MonoBehaviour
{
    public static int hp = 1;
    public int enemyflag = 0;
    int hpflag;
    public Text HPLabel;
    int itemflag;

    // Start is called before the first frame update
    void Start()
    {
        hp = 1;
        //追加
        HPLabel.text = "" + hp;
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
        itemflag = victory.getvic();

        if (hpflag == 1)
        {
            hp -= 1;
            HPLabel.text = "" + hp;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
        if (itemflag == 1)
        {
            Debug.Log("a");
            hp += 1;
            HPLabel.text = "" + hp;
        }
    }
    public static int gethp()
    {
        return hp;
    }
}
