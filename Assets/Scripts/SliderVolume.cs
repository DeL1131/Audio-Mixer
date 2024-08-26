using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public abstract class SliderVolume : MonoBehaviour
{
    protected const string CommandMasterVolume = "MasterVolume";
    protected const string CommandBackGroundMusic = "BackGroundMusic";
    protected const string CommandSelectedMusic = "SelectedMusic";

    [SerializeField] protected ToggleMuteChange ToggleMuteChange;

    public AudioMixerGroup Mixer;
    protected Slider Slider;

    protected float MinVolumeValue = 0.0001f;
    protected float MaxVolumeValue = 1f;
    protected float DecibelConversionFactor = 100f;

    private void OnEnable()
    {
        Slider = GetComponent<Slider>();
        Slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        Slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    protected abstract void ChangeVolume(float volume);
}