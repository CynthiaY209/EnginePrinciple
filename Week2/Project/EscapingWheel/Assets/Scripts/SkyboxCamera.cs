using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxCamera : MonoBehaviour
{
    public float rot = 0;
    public Skybox sky;
    // Use this for initialization  
    void Start()
    {
        sky = GetComponent<Skybox>();
    }

    // Update is called once per frame  
    void Update()
    {
        rot += 0.7f * Time.deltaTime;
        rot %= 360;
        sky.material.SetFloat("_Rotation", rot);
    }
}
