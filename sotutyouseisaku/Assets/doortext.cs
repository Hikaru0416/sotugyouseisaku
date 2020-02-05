using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doortext : MonoBehaviour
{
    public Text door;
    int text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text = Star.getdoor();
        if (text == 1)
        {
            door.text = "扉を探せ";
        }
    }
}
