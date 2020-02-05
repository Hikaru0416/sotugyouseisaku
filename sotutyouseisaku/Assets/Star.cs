using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    private GameObject[] starObjects;
    public GameObject door;
    bool flag = false;
    public static int doorflag = 0;
    public static int starcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        starcount = 0;
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            starcount += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        starObjects = GameObject.FindGameObjectsWithTag("star");

        //print(starObjects.Length);


        //何故か一個反応しないから一個は何処かに隠してごまかす！
        if (starObjects.Length == 1&&!flag)
        {
            doorflag = 1;
            flag = true;
            Instantiate<GameObject>(door, transform.position + Vector3.up*10, Quaternion.identity);
        }
        else
        {
            doorflag = 0;
        }

        transform.Rotate(new Vector3(0, 3, 0));
    }
    public static int getdoor()
    {
        return doorflag;
    }
    public static int getcount()
    {
        return starcount;
    }
}
