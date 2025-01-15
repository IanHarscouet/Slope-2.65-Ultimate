using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class OptionMenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Resolution[] possibleResolutions;
    public Dropdown resolutionsMenu;

    public void Start()
    {
        resolutionsMenu = GetComponent<Dropdown>();
        possibleResolutions = Screen.resolutions;
        
        List<string> resolutionOptions = new List<string>();

        for (int i = 0; i < possibleResolutions.Length; i++)
        {
            string Option = possibleResolutions[i].width + " x " + possibleResolutions[i].height;
            resolutionOptions.Add(Option);
        }
        resolutionsMenu.AddOptions(resolutionOptions);
    }
    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume",volume);
    }
    public void Fullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }
}
