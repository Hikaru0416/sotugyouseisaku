using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    int boss1flag;
    int boss2flag;
    int boss3flag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        boss1flag = boss.getboss1();
        boss2flag = boss.getboss2();
        boss3flag = boss.getboss3();

        if (Input.GetMouseButtonDown(0) && boss1flag == 1)
        {
            SceneManager.LoadScene("Boss1");
        }
        if (Input.GetMouseButtonDown(0) && boss2flag == 1)
        {
            SceneManager.LoadScene("Boss2");
        }
        if (Input.GetMouseButtonDown(0) && boss3flag == 1)
        {
            SceneManager.LoadScene("Boss3");
        }
    }
}
