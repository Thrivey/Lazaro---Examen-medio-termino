using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float life = 1;
    public int speed;

    public void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
    }
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
