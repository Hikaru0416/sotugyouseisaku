using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UniUni : MonoBehaviour
{
    GameObject Capsule;
    Animator animator;
    int yesflag;
    int noflag;

    int boss1flag;
    int boss2flag;
    int boss3flag;

    void victoryend()
    {
        if (boss1flag == 1)
        {
            SceneManager.LoadScene("Boss1");
        }
        if (boss2flag == 1)
        {
            SceneManager.LoadScene("Boss2");
        }
        if (boss3flag == 1)
        {
            SceneManager.LoadScene("Boss3");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("death", true);
    }

    // Update is called once per frame
    void Update()
    {
        yesflag = Yes.getyes();
        noflag = No.getno();

        boss1flag = boss.getboss1();
        boss2flag = boss.getboss2();
        boss3flag = boss.getboss3();

        //animator.SetBool("death", true);


        if (yesflag == 1)
        {

            Capsule = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                Capsule = hit.collider.gameObject;

            }
            animator.SetBool("death", false);
            animator.SetBool("is_victory", true);
        }

        if (noflag == 1)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
  
}
