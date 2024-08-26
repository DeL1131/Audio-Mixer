using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]

public class ToggleMuteChange : MonoBehaviour
{
    protected const string CommandMasterVolume = "MasterVolume";

    [SerializeField] private AudioMixerGroup Mixer;

    private Toggle _toggle;
    private float _currentvolume;

    public bool IsMuted { get; private set; }

    private void OnEnable()
    {
        _toggle = GetComponent<Toggle>();

        _toggle.onValueChanged.AddListener(MuteAllMusic);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(MuteAllMusic);
    }

    public void MuteAllMusic(bool enabled)
    {
        if (enabled)
        {
            IsMuted = true;
            Mixer.audioMixer.GetFloat(CommandMasterVolume, out _currentvolume);
            Mixer.audioMixer.SetFloat(CommandMasterVolume, -80);
        }
        else
        {
            IsMuted= false;
            Mixer.audioMixer.SetFloat(CommandMasterVolume, _currentvolume);
        }
    }
}