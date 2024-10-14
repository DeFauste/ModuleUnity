using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    [SerializeField] private AudioSource clip;
    public void Play()
    {
        if(clip != null)
        {
            clip.Play();
        }
    }
}
