using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respone : MonoBehaviour
{
    int Respone;
    public Text res;

    // Start is called before the first frame update
    void Start()
    {
        Respone = HP2.getres();
    }

    // Update is called once per frame
    void Update()
    {
        res.text = "あと" + Respone + "回復活可";
        if (Respone <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
