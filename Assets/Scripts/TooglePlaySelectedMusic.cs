using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
[RequireComponent (typeof(Toggle))]

public class TogglePlaySelectedMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    private Toggle _toggle;

    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
        _toggle = GetComponent<Toggle>();

        _toggle.onValueChanged.AddListener(PlayMusic);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(PlayMusic);
    }

    public void PlayMusic(bool enabled)
    {
        if (enabled)
            _audioSource.Play();
        else
            _audioSource.Stop();
    }
}