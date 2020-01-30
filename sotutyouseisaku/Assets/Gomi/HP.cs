using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public Text HPLabel;
    int hp = 3;
    int hpflag;

    // Start is called before the first frame update
    void Start()
    {
        //追加
        HPLabel.text = "" + hp;
    }

    // Update is called once per frame
    void Update()
    {
        hpflag = goblin.getHP();

        if (hpflag==1)
        {
            hp += 1;
            HPLabel.text = "" + hp;
        }
        if (Input.GetMouseButtonDown(1))
        {
            hp -= 1;
            HPLabel.text = "" + hp;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
}
