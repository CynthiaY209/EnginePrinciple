using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject[] characters;

    // Start is called before the first frame update
    void Start()
    {
        characters[1].gameObject.SetActive(false);
        characters[2].gameObject.SetActive(false);
        characters[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchtoSpringBone()
    {
        characters[1].gameObject.SetActive(false);
        characters[2].gameObject.SetActive(false);
        characters[0].gameObject.SetActive(true);
    }

    public void SwitchtoCloth()
    {
        characters[0].gameObject.SetActive(false);
        characters[2].gameObject.SetActive(false);
        characters[1].gameObject.SetActive(true);
    }

    public void SwitchtoSpringBoneandCloth()
    {
        characters[0].gameObject.SetActive(false);
        characters[1].gameObject.SetActive(false);
        characters[2].gameObject.SetActive(true);
    }
}
