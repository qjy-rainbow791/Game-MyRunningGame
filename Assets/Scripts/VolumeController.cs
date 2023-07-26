using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used to control the volume of the game
public class VolumeController : MonoBehaviour
{
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("volume"))
        {
            m_AudioSource.volume = PlayerPrefs.GetFloat("volume");
        }
        else
        {
            m_AudioSource.volume = 0.5f;
        }
    }
}
