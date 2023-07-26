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
        // ��Slider��ֵ����Ϊ��ǰ������С
        volumeSlider.value = audioSource.volume;
        UpdateValueText();
    }

    public void OnSliderValueChanged()
    {
        // �����ı�����
        UpdateValueText();
        // ��Slider��ֵ����Ϊ��Ϸ��������С
        AudioSource audioSource = camera.GetComponent<AudioSource>();
        audioSource.volume = volumeSlider.value;
    }

    void UpdateValueText()
    {
        // ��Slider��ֵת��Ϊ�ַ����������丳ֵ���ı�����
        valueText.text = string.Format("{0:F0}", volumeSlider.value*100);
        valueText.text = "VOLUME: " + valueText.text;
        PlayerPrefs.SetFloat("volume",volumeSlider.value);
    }
}
