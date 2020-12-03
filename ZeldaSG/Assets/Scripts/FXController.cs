using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXController : MonoBehaviour
{
    public ParticleSystem FXLogoOutline;
    public ParticleSystem FXWall1;
    public ParticleSystem FXLogo;
    public ParticleSystem FXWall2;
    public ParticleSystem FXWall3;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Anima());
        }
    }
    IEnumerator Anima()
    {
        FXLogo.Play();
        FXWall2.Play();
        FXWall3.Play();
        //yield return new WaitForSeconds(0.2f);
        FXLogoOutline.Stop();
        yield return new WaitForSeconds(2.0f);
        FXWall1.Stop();
    }
}
