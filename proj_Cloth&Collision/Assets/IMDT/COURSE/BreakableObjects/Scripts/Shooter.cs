using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Transform BulletPrefabRed;

    // Use this for initialization
    void Start()
    {
        //SetBulletString ();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //SetBulletString();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Transform clone;
            clone = Instantiate(BulletPrefabRed, ray.origin, Quaternion.identity) as Transform;
            clone.name = "Bullet";
            clone.gameObject.GetComponent<Bullet>().SetDir(ray.direction);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

