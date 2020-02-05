using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    public GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("startPush");
        startButton.gameObject.SetActive(false);
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
}
