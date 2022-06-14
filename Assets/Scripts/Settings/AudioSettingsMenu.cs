using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }

    public void SetEnemyVolume(float volume) 
    {
        audioMixer.SetFloat("EnemyVolume", volume);
    }

    public void SetPlayerVolume(float volume) 
    {
        audioMixer.SetFloat("PlayerVolume", volume);
    }

}
