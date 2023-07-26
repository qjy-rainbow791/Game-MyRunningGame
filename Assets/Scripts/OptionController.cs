using UnityEngine.UI;
using UnityEngine;

public class OptionController : MonoBehaviour
{
    public Text valueText;
    public Camera camera;
    private Slider volumeSlider;

    void Start()
    {
        AudioSource audioSource = camera.GetComponent<AudioSource>();
        volumeSlider = GetComponent<Slider>();
        // 将Slider的值设置为当前音量大小
        volumeSlider.value = audioSource.volume;
        UpdateValueText();
    }

    public void OnSliderValueChanged()
    {
        // 更新文本内容
        UpdateValueText();
        // 将Slider的值设置为游戏的音量大小
        AudioSource audioSource = camera.GetComponent<AudioSource>();
        audioSource.volume = volumeSlider.value;
    }

    void UpdateValueText()
    {
        // 将Slider的值转换为字符串，并将其赋值给文本内容
        valueText.text = string.Format("{0:F0}", volumeSlider.value*100);
        valueText.text = "VOLUME: " + valueText.text;
        PlayerPrefs.SetFloat("volume",volumeSlider.value);
    }
}
