using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBasicSound : MonoBehaviour
{
    public string stopEventName = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Stop()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");

        if (!string.IsNullOrEmpty(stopEventName))
        {
            AkSoundEngine.PostEvent(stopEventName, mainCamera);
            //isPlay = true;
        }
    }
}
