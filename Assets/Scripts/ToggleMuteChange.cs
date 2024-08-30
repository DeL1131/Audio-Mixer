using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]

public class ToggleMuteChange : MonoBehaviour
{
    protected const string CommandMasterVolume = "MasterVolume";

    [SerializeField] private AudioMixerGroup _mixer;

    private Toggle _toggle;
    private float _currentvolume;
    private float _minVolume = -80f;

    public bool IsMuted { get; private set; }

    private void Awake()
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
            _mixer.audioMixer.GetFloat(CommandMasterVolume, out _currentvolume);
            _mixer.audioMixer.SetFloat(CommandMasterVolume, _minVolume);
        }
        else
        {
            IsMuted= false;
            _mixer.audioMixer.SetFloat(CommandMasterVolume, _currentvolume);
        }
    }
}