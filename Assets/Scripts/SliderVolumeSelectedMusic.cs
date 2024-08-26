using UnityEngine;

public class SliderVolumeSelectedMusic : SliderVolume
{
    protected override void ChangeVolume(float volume)
    {
        volume = Mathf.Clamp(volume, MinVolumeValue, MaxVolumeValue); ;

        if (ToggleMuteChange.IsMuted != true)
            Mixer.audioMixer.SetFloat(CommandSelectedMusic, Mathf.Log10(volume) * DecibelConversionFactor);
    }
}