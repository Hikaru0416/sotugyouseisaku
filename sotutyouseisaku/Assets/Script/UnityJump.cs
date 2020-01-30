using UnityEngine;
public class UnityJump : MonoBehaviour
{
    void Update()
    {
        Animator anim = GetComponent<Animator>();   // ...(1)

        if (Input.GetKey(KeyCode.Space))   // ...(2)
        {
            anim.SetBool("Jump", true);
        }

        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);   // ...(3)
        if (state.IsName("Locomotion.Jump"))   // ...(4)
        {
            anim.SetBool("Jump", false);
        }
    }
}
