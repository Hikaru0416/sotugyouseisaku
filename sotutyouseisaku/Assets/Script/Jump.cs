using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Collider JumpCollider;
    // Start is called before the first frame update
    void Start()
    {
        JumpCollider = GameObject.Find("Set_WMU02_TwinDagger").GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           

            //武器コライダーをオンにする
            JumpCollider.enabled = true;

            //一定時間後にコライダーの機能をオフにする
            Invoke("ColliderReset", 0.5f);
        }
    }
}
