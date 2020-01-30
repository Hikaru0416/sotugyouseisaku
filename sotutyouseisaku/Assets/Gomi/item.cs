using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    int playerflag = 0;
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            playerflag = 1;

            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerflag == 1)
        {
            Destroy(gameObject);
        }
        
    }
}
