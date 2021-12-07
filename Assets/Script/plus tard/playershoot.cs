using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershoot : MonoBehaviour
{
    public float shootspeed;
    public float shootTimer;
    public float shootPost;

    private bool isShooting;

    public Transform shootPos;
    public GameObject bullet;

    void Start()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isShooting)
        {
            StartCoroutine(Shoot());
        }
        
    }

    IEnumerator Shoot() 
    {
        int direction()
        {
            if(transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }
        isShooting = true;
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootspeed * direction() * Time.fixedDeltaTime, 0f);
        newBullet.transform.localScale = new Vector2(newBullet.transform.localScale.x * direction(), newBullet.transform.localScale.y);

        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
    
}
