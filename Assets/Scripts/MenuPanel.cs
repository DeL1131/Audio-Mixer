using UnityEngine;
using UnityEngine.Audio;

public class MenuPanel : MonoBehaviour
{
    public const string CommandMasterVolume = "MasterVolume";
    public const string CommandBackGroundMusic = "BackGroundMusic";
    public const string CommandSelectedMusic = "SelectedMusic";

    public AudioMixerGroup Mixer;
    private float a;

    public void MuteAllMusic(bool enabled)
    {

        if (enabled)
        {
            Mixer.audioMixer.GetFloat(CommandMasterVolume, out a);
            Mixer.audioMixer.SetFloat(CommandMasterVolume, -80);
        }
        else
            Mixer.audioMixer.SetFloat(CommandMasterVolume, a);
    }

    public void ChangeBackGroundVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(CommandBackGroundMusic, Mathf.Lerp(-80, 0, volume));
    }

    public void OverAllVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(CommandMasterVolume, Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeVolumeSelectedMusic(float volume)
    {
        Mixer.audioMixer.SetFloat(CommandSelectedMusic, Mathf.Lerp(-80, 0, volume));
    }
}