using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblin : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;
    private int hp = 3;
    int itemflag = 0;
    public static int hpflag = 0;
    public AudioClip sound;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "item")
        {
            itemflag = 1;
        }
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        Vector3 pos = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);

        float x = Input.GetAxis("Horizontal") * speed;
        rb.AddForce(x, 0, 0);

        if (itemflag == 1)
        {
            audio.PlayOneShot(sound);
            hp += 1;
            Debug.Log(hp);
            hpflag = 1;
            itemflag = 0;
            //unityちゃんのdamageとhealのanimationにanimationeventをつけて回復とダメージによるhpの増減をする。
        }
    }
    public static int getHP()
    {
        return hpflag;
    }
}
