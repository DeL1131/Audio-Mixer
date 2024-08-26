using UnityEngine;

public class SliderOverallVolume : SliderVolume
{
    protected override void ChangeVolume(float volume)
    {
        volume = Mathf.Clamp(volume, MinVolumeValue, MaxVolumeValue); ;

        if (ToggleMuteChange.IsMuted != true)
            Mixer.audioMixer.SetFloat(CommandMasterVolume, Mathf.Log10(volume) * DecibelConversionFactor);
    }
}