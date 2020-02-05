using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laststar : MonoBehaviour
{
    private GameObject[] starObjects;
    int starflag = 0;
    bool flag;

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            starflag = 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flag = HP2.getflag();

        if (starflag == 1)
        {
            SceneManager.LoadScene("gameclear");
            flag = false;
        }

        transform.Rotate(new Vector3(0, 3, 0));
    }
}
