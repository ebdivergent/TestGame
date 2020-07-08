using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherEnemy : MonoBehaviour
{
    public Transform bullet;
    public int BulletForce = 10;
    public Transform enemy;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Shoot();
            Invoke("Death", 3f);

        }
    }
    void Shoot()
    {
        Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
        BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
        LookAt();
    }
    void LookAt()
    {
        transform.LookAt(enemy.transform);
    }
    void Death()
    {
        Destroy(gameObject);

    }
}
