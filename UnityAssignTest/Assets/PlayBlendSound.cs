using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySequenceSound : MonoBehaviour
{
    public string playSeqEventName = null;
    public int dayTimeValue=55;
    // Start is called before the first frame update
    void Start()
    {
        if (dayTimeValue < 0)
            dayTimeValue = 0;
        else if (dayTimeValue > 100)
            dayTimeValue = 100;
    }

    // Update is called once per frame
    void PlaySeq()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");

        if (!string.IsNullOrEmpty(playSeqEventName))
        {
            AkSoundEngine.SetRTPCValue("DayTime", dayTimeValue);
            AkSoundEngine.PostEvent(playSeqEventName, mainCamera);
        }
    }
}
