using UnityEngine;

public class SliderOverallVolume : SliderVolume
{
    protected override void ChangeVolume(float volume)
    {
        if (ToggleMuteChange.IsMuted != true)
            Mixer.audioMixer.SetFloat(CommandMasterVolume, Mathf.Lerp(-80, 0, volume));
    }
}