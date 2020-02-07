using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP2 : MonoBehaviour
{
    int hp;
    public Text HPLabel;
    public static int res = 3;
    public static bool flag = false;
    int hpflag;
    int timeflag;

    // Start is called before the first frame update
    void Start()
    {
        if (flag == false)
        {
            hp = UnityHP.gethp();
        }
        else
        {
            hp = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        hpflag = boss.gethp();
        timeflag = BossTimer.getBTime();

        if (hpflag == 1)
        {
            hp -= 2;
            HPLabel.text = "" + hp;
        }
        if (hp<=0)
        {
            res -= 1;
            SceneManager.LoadScene("gameover1");
            flag = true;
        }
        if (timeflag == 1)
        {
            res -= 1;
            SceneManager.LoadScene("gameover1");
        }
        if (res <= 0)
        {
            SceneManager.LoadScene("gameover");
            res = 3;
            flag = false;
        }
        HPLabel.text = "" + hp;
    }
    public static int getres()
    {
        return res;
    }
    public static bool getflag()
    {
        return flag;
    }
}
