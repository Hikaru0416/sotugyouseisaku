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

    void victoryend()
    {
        SceneManager.LoadScene("Boss1");
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
