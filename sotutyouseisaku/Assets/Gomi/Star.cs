using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{
    private GameObject[] starObjects;

  

    // Start is called before the first frame update
    void Start()
    {
      
    }



    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("star取った!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        starObjects = GameObject.FindGameObjectsWithTag("star");

        //print(starObjects.Length);


        //何故か一個反応しないから一個は何処かに隠してごまかす！
        if (starObjects.Length == 1)
        {
            SceneManager.LoadScene("GameClear");
        }

        transform.Rotate(new Vector3(0, 3, 0));

    }
}

  

