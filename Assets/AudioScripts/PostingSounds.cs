using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PostingSounds : MonoBehaviour
{

    void Update()
    {
        TestSoundsKeyBinding();
    }

    void TestSoundsKeyBinding()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            AkSoundEngine.PostEvent("Play_Clap", gameObject);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            AkSoundEngine.PostEvent("Play_Whistle", gameObject);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            AkSoundEngine.PostEvent("Play_Clang", gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AkSoundEngine.PostEvent("Play_Sine", gameObject);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            AkSoundEngine.PostEvent("Stop_Sine", gameObject);
        }
               
    }

}
