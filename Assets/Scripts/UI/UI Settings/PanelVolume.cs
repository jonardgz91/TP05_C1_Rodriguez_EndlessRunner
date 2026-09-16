using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PanelVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider sliderMaster;
    [SerializeField] private Slider sliderBackgroud;
    [SerializeField] private Slider sliderSfx;
    [SerializeField] private Slider sliderUi;

    private void Awake()
    {
        sliderMaster.onValueChanged.AddListener(OnSliderMasterChanged);
        sliderBackgroud.onValueChanged.AddListener(OnsliderBackgroudChanged);
        sliderSfx.onValueChanged.AddListener(OnSliderSfxChanged);
        sliderUi.onValueChanged.AddListener(OnSliderUiChanged);
    }

    private void Start()
    {
        float volume = 0;
        mixer.GetFloat("VolumeMaster", out volume);
        sliderMaster.value = volume;

        mixer.GetFloat("VolumeBackgroud", out volume);
        sliderBackgroud.value = volume;

        mixer.GetFloat("VolumeSFX", out volume);
        sliderSfx.value = volume;

        mixer.GetFloat("VolumeUI", out volume);
        sliderUi.value = volume;
    }

    private void OnDestroy()
    {
        sliderMaster.onValueChanged.RemoveAllListeners();
        sliderBackgroud.onValueChanged.RemoveAllListeners();
        sliderSfx.onValueChanged.RemoveAllListeners();
        sliderUi.onValueChanged.RemoveAllListeners();
    }

    private void OnSliderMasterChanged(float value) => ModifyMixerVolume("VolumeMaster", value);
    private void OnsliderBackgroudChanged(float value) => ModifyMixerVolume("VolumeBackgroud", value);
    private void OnSliderSfxChanged(float value) => ModifyMixerVolume("VolumeSFX", value);
    private void OnSliderUiChanged(float value) => ModifyMixerVolume("VolumeUI", value);

    private void ModifyMixerVolume(string parameter, float volume)
    {
        float finalVolume = Mathf.Clamp(Mathf.Log10(volume) * 30f, -80f, 0f);
        mixer.SetFloat(parameter, finalVolume);
    }
}