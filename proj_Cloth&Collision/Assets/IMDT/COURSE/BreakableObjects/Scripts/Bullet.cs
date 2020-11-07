using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Vector3 dir;

    public void SetDir(Vector3 dirFrom)
    {
        dir = dirFrom;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Crate")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        //dir = transform.forward;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed);
        Vector3 distance = transform.position - Camera.main.transform.position;
        if (distance.magnitude > 30)
            Destroy(gameObject);

    }
}
