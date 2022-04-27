using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTestSoundsVolume : MonoBehaviour
{
    public AK.Wwise.RTPC PlayerTestSoundsVolumeRTPC;
    private float PlayerTestSounds;

    TextMeshProUGUI textMesh;

    void Start()
    {
        PlayerTestSounds = 0f;
        PlayerTestSoundsVolumeRTPC.SetGlobalValue(PlayerTestSounds);
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = "Player Test Sounds Volume : " + PlayerTestSounds;
    }

    void Update()
    {
        PlayerTestSoundsVolumeAdjustment();
    }

    void PlayerTestSoundsVolumeAdjustment()
    {
        if (Input.GetKey(KeyCode.Period))
        {
            if (PlayerTestSounds <= 12f)
            {
                PlayerTestSounds += 0.1f;
            }
            if (textMesh != null)
            {
                textMesh.text = "Player Test Sounds Volume : " + (int)PlayerTestSounds;
            }
        }
        else if (Input.GetKey(KeyCode.Comma))
        {
            if (PlayerTestSounds >= -12f)
            {
                PlayerTestSounds -= 0.1f;
            }
            if (textMesh != null)
            {
                textMesh.text = "Player Test Sounds Volume : " + (int)PlayerTestSounds;
            }
        }
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            PlayerTestSounds = 0f;

            if (textMesh != null)
            {
                textMesh.text = "Player Test Sounds Volume : " + (int)PlayerTestSounds;
            }

        }
        PlayerTestSoundsVolumeRTPC.SetGlobalValue(PlayerTestSounds);
    }

}