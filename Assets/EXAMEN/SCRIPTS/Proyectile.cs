using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{
    public float life = 16;
    public int speed;

    public void Update()
    {
        transform.localPosition += transform.forward * Time.deltaTime * speed;
    }
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<Score>().AddScore();
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

