using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starcount : MonoBehaviour
{
    public Text StarLabel;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        count = Star.getcount();
        count = 5 - count;
        StarLabel.text = "残り" + count + "コ";
    }
}
