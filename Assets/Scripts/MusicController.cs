using UnityEngine;

[RequireComponent(typeof(AudioSource))]


public class MusicController : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(bool enabled)
    {
        if (enabled)
            _audioSource.Play();
        else
            _audioSource.Stop();
    }
}