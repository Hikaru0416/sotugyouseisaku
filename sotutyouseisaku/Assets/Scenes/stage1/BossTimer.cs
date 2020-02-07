using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossTimer : MonoBehaviour
{
    float bosstimer;
    public static int timeflag;

    // Start is called before the first frame update
    void Start()
    {
        bosstimer = Timer.getBossTimer();
        timeflag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bosstimer -= Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = bosstimer.ToString("0"); //小数2桁にして表示

        if (bosstimer <= 0)
        {
            timeflag = 1;
        }
    }
    
    public static int getBTime()
    {
        return timeflag;
    }
}
