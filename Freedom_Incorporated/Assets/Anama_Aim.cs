using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anama_Aim : MonoBehaviour
{
    Animator animator;

    //float aim = Input.GetAxis("Aim");

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //if (aim > 0)
        //{
        //    Debug.Log("fjdi");
        //}

        if (Input.GetAxis("Aim") > 0)
        {
            //animator.SetTrigger("Aim_1");
            animator.SetBool("Aim", true);

        }
        
        if (Input.GetAxis("Aim") <= 0)
        {
            //animator.SetTrigger("Aim_1");
            animator.SetBool("Aim", false);

        }
    }
}
