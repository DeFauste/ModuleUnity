using UnityEngine;
using UnityEngine.Audio;

public class AudioMixer : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    
    public void MasterVolume(float value)
    {
        Debug.Log(Mathf.Lerp(-80, 0, value));
        _mixer.audioMixer.SetFloat("Master", Mathf.Lerp(-80, 0, value));
    }
    public void MusicVolume(float value)
    {
        _mixer.audioMixer.SetFloat("Music", Mathf.Lerp(-80, 0, value));
    }
    public void SFXVolume(float value)
    {
        _mixer.audioMixer.SetFloat("SFX", Mathf.Lerp(-80, 0, value));
    }
}
