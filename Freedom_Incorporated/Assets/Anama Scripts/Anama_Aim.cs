using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anama_Aim : MonoBehaviour
{
    Animator animator;

    bool canAim;

    float aimAngle;

    public GameObject anamaArm;

    public GameObject projectile;

    public Transform shootPos;

    bool canShoot;

    

    void Start()
    {
        animator = GetComponent<Animator>();

        aimAngle = 0;

        anamaArm.transform.eulerAngles = transform.eulerAngles + new Vector3(0f, 0f, 0f);

        canShoot = true;
    }

    void Update()
    {
        ArmRotation();

        

        //ShootProjectile();
    }

    

    void ArmRotation()
    {
        if (Input.GetAxis("Aim") > 0)
        {
            animator.SetBool("Aim", true);

            anamaArm.transform.eulerAngles = transform.eulerAngles + new Vector3(0f, 0f, aimAngle);

            ShootProjectile();
        }

        if (Input.GetAxis("Aim") <= 0)
        {
            animator.SetBool("Aim", false);

            anamaArm.transform.eulerAngles = transform.eulerAngles + new Vector3(0f, 0f, 0f);
        }

        AimCalculator();
    }

    void AimCalculator()
    {
        float xAim = Input.GetAxis("HorizontalAim") * Time.deltaTime;
        float yAim = Input.GetAxis("VerticalAim") * Time.deltaTime;

        aimAngle = Mathf.Atan2(yAim, xAim) * Mathf.Rad2Deg +90;
    }

    void ShootProjectile()
    {
        if (Input.GetAxis("Shoot") > 0 && canShoot == true) 
        {
            GameObject bullet = Instantiate(projectile, 
                shootPos.transform.position, anamaArm.transform.rotation) as GameObject;

            //bullet.GetComponent<Rigidbody2D>().AddForce(anamaArm.transform.forward * 10);

            //canShoot = false;

            //set up shooting timer
        }

    }

}
