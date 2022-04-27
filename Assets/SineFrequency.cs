using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SineFrequency : MonoBehaviour
{

    public AK.Wwise.RTPC SineFrequencyRTPC;
    private int SineFreq;

    TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        SineFreq = 440;
        SineFrequencyRTPC.SetGlobalValue(SineFreq);
        textMesh.text = "Sine Frequency : " + SineFreq;
    }

    void Update()
    {
        SineFrequencyAdjustment();
    }

    void SineFrequencyAdjustment()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SineFreq < 10000)
            {
                SineFreq += (SineFreq / 10);
            }

            if (textMesh != null)
            {
                textMesh.text = "Sine Frequency : " + SineFreq;
            }

        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (SineFreq >= 40)
            {
                SineFreq -= (SineFreq / 10);
            }

            if (textMesh != null)
            {
                textMesh.text = "Sine Frequency : " + SineFreq;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SineFreq = 440;

            if (textMesh != null) 
            {
                textMesh.text = "Sine Frequency : " + SineFreq;
            }
 
        }

        SineFrequencyRTPC.SetGlobalValue(SineFreq);

    }

}
