using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletObject;
    public Transform bulletOut;
    public float shootForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(bulletObject, bulletOut.position, Quaternion.identity);
            bulletClone.GetComponent<Rigidbody>().AddForce(shootForce * bulletOut.forward);
        }
    }
}
