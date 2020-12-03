using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SCControl : MonoBehaviour
{
    public GameObject go;
    private Material material;
    private float dissolve;
    void Start()
    {
        material = go.GetComponent<MeshRenderer>().material;
        dissolve = 0;
        
        DOTween.To(() => dissolve, X => dissolve = X, 1.0f, 10);
    }
    private void Update()
    {
        material.SetFloat("_Dissolve", dissolve);
    }
}
