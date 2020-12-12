using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBasicSound : MonoBehaviour
{
    public string playEventName = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PlayOrStop()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");

        if(!string.IsNullOrEmpty(playEventName))
        {
            AkSoundEngine.PostEvent(playEventName, mainCamera);
        }
    }
}
