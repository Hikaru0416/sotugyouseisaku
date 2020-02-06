using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{ 
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "water")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        if (pos.y <= -10)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
