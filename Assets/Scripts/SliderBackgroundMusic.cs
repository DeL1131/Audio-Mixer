using UnityEngine;

public class SliderBackgroundMusic : SliderVolume
{
    protected override void ChangeVolume(float volume)
    {
        volume = Mathf.Clamp(volume, MinVolumeValue, MaxVolumeValue);;

        if (ToggleMuteChange.IsMuted != true)
            Mixer.audioMixer.SetFloat(CommandBackGroundMusic, Mathf.Log10(volume) * DecibelConversionFactor);
    }
}