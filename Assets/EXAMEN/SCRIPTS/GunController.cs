using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject ProyectilePrefab;
    public float forcer;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(ProyectilePrefab, FirePoint.position, FirePoint.rotation);
            clone.GetComponent<Rigidbody>().AddForce(transform.forward * forcer);
        }
    }
}
