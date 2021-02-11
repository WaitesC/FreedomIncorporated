using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
        transform.Rotate(0, 0, 270, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
