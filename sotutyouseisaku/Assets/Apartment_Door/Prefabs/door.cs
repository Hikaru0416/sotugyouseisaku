using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    int playerflag = 0;
    public static int bossflag = 0;
    public int boss1flag = 1;
    public int boss2flag = 1;
    public int boss3flag = 1;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerflag = 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerflag == 1&& boss1flag == 1)
        {
            SceneManager.LoadScene("BOSS1");
            bossflag = 1;
        }
        if (playerflag == 1 && boss2flag == 1)
        {
            SceneManager.LoadScene("BOSS2");
            bossflag = 1;
        }
        if (playerflag == 1 && boss3flag == 1)
        {
            SceneManager.LoadScene("BOSS3");
            bossflag = 1;
        }
    }
    public static int getBoss()
    {
        return bossflag;
    }
}
