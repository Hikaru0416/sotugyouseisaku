using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Yes : MonoBehaviour
{
    public static int yesflag;
   
    // Start is called before the first frame update
    void Start()
    {
        yesflag = 0;
    }

    public void OnClick()
    {
        yesflag = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public static int getyes()
    {
        return yesflag;
    }
}
