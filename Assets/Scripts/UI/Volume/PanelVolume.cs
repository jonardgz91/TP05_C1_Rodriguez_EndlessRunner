using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PanelVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider sliderMaster;
    [SerializeField] private TMP_Text textMaster;
    [SerializeField] private Slider sliderBackgroud;
    [SerializeField] private TMP_Text textBackgroud;
    [SerializeField] private Slider sliderSfx;
    [SerializeField] private TMP_Text textSfx;
    [SerializeField] private Slider sliderUi;
    [SerializeField] private TMP_Text textUi;

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
        textMaster.text = sliderMaster.value.ToString("F2");

        mixer.GetFloat("VolumeBackgroud", out volume);
        sliderBackgroud.value = volume;
        textBackgroud.text = sliderBackgroud.value.ToString("F2");

        mixer.GetFloat("VolumeSFX", out volume);
        sliderSfx.value = volume;
        textSfx.text = sliderSfx.value.ToString("F2");

        mixer.GetFloat("VolumeUI", out volume);
        sliderUi.value = volume;
        textUi.text = sliderUi.value.ToString("F2");
    }

    private void OnDestroy()
    {
        sliderMaster.onValueChanged.RemoveAllListeners();
        sliderBackgroud.onValueChanged.RemoveAllListeners();
        sliderSfx.onValueChanged.RemoveAllListeners();
        sliderUi.onValueChanged.RemoveAllListeners();
    }

    private void OnSliderMasterChanged(float value)
    {
        ModifyMixerVolume("VolumeMaster", value);
        textMaster.text = value.ToString("F2");
    }

    private void OnsliderBackgroudChanged(float value)
    {
        ModifyMixerVolume("VolumeBackgroud", value);
        textBackgroud.text = value.ToString("F2");
    }

    private void OnSliderSfxChanged(float value)
    {
        ModifyMixerVolume("VolumeSFX", value);
        textSfx.text = value.ToString("F2");
    }

    private void OnSliderUiChanged(float value)
    {
        ModifyMixerVolume("VolumeUI", value);
        textUi.text = value.ToString("F2");
    }

    private void ModifyMixerVolume(string parameter, float volume)
    {
        float finalVolume = Mathf.Clamp(Mathf.Log10(volume) * 30f, -80f, 0f);
        mixer.SetFloat(parameter, finalVolume);
    }
}