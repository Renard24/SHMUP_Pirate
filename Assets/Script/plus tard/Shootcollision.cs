using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootcollision : MonoBehaviour
{
    public float moveSpeed;
    private float maxSpeed = 5f;
    private Vector2 input;
    public GameObject projectile;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject bullet = Instantiate(projectile,
 transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
        }

        input = new Vector2(Input.GetAxis("Horizontal_2"), Input.GetAxis("Vertical_2"));

        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
        {
            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

        }

        print(input);
    }
}
