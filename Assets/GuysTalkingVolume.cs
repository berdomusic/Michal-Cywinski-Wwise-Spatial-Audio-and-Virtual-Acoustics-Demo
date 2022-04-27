using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuysTalkingVolume : MonoBehaviour
{
    public AK.Wwise.RTPC GuysTalkingVolumeRTPC;
    private ushort GuysVolume;

    TextMeshProUGUI textMesh;

    void Start()
    {
        GuysVolume = 100;
        GuysTalkingVolumeRTPC.SetGlobalValue(GuysVolume);
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = "Guys Talking Volume : " + GuysVolume;
    }

    void Update()
    {
        GuysTalkingVolumeAdjustment();
    }

    void GuysTalkingVolumeAdjustment()
    {
        if (Input.GetKey(KeyCode.Equals))
        {
            if (GuysVolume != 100)
            {
                GuysVolume += 2;                
            }
            if (textMesh != null)
            {
                textMesh.text = "Guys Talking Volume : " + GuysVolume;
            }
        }
        else if (Input.GetKey(KeyCode.Minus))
        {
            if (GuysVolume != 0)
            {
                GuysVolume -= 2;
            }
            if (textMesh != null)
            {
                textMesh.text = "Guys Talking Volume : " + GuysVolume;
            }
        }

        GuysTalkingVolumeRTPC.SetGlobalValue(GuysVolume);
    }

}