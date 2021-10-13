using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 10;

    Vector2 lookDirection;
    float lookAngle;

    void Start()
    {

    }

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y - firePoint.position.y, lookDirection.x - firePoint.position.x) * Mathf.Rad2Deg;
        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);

        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = new Vector3(firePoint.position.x, firePoint.position.y, 0);
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed;
            Destroy(bulletClone, 5);
        }


    }
}