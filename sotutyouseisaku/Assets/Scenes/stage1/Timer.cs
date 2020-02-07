using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float countTime = 600;
    // Use this for initialization
    void Start()
    {
        countTime = 600;
    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = countTime.ToString("0"); //小数2桁にして表示

        if (countTime <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

    public static float getBossTimer()
    {
        return countTime;
    }
}