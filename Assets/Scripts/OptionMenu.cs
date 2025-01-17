using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class OptionMenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Resolution[] possibleResolutions;
    public TMP_Dropdown resolutionsMenu;
    public float baseVolume = -20;

    public void Start()
    {        
        possibleResolutions = Screen.resolutions;
        
        List<string> resolutionOptions = new List<string>();

        for (int i = 0; i < possibleResolutions.Length; i++)
        {
            string Option = possibleResolutions[i].width + " x " + possibleResolutions[i].height;
            resolutionOptions.Add(Option);
        }
        resolutionsMenu.AddOptions(resolutionOptions);
        SetVolume(baseVolume);
        
    }
    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume",volume);
    }
    public void Fullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = possibleResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height,Screen.fullScreen);
    }
}
