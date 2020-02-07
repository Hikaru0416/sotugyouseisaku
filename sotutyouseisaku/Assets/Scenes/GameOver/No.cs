using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class No : MonoBehaviour
{
    public static int noflag;
    public GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("startPush");
        startButton.gameObject.SetActive(false);
        noflag = 0;
    }

    public void OnClick()
    {
        noflag = 1;
    }

    // Update is called once per frame
   void Update()
    {
      
    }
    IEnumerator startPush()
    {
        startButton.gameObject.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        startButton.gameObject.SetActive(true);
    }
        public static int getno()
            
    {
        return noflag;
    }

}
