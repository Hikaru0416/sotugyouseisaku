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

    // Start is called before the first frame update
    void Start()
    {
        if (flag == false)
        {
            hp = UnityHP.gethp();
        }
        else
        {
            hp = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(1))
        {
            hp -= 1;
        }
        if (hp<=0)
        {
            res -= 1;
            SceneManager.LoadScene("gameover");
            flag = true;
        }
        if (res <= 0)
        {
            SceneManager.LoadScene("gameover2");
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
