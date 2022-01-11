using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenuOptions : MonoBehaviour
{
    #region VideoSettings (InClass)
    Resolution[] Resolutions;
    public TMP_Dropdown ResolutionDropdown;
    bool IsFullscreen;
    public Toggle FullscreenToggle;
    #endregion

    #region SoundSettings (InClass)
    public AudioMixer AudioMixer;

    float MasterVolume;
    public Slider MasterVolumeSlider;
    public Toggle MasterMuteToggle;
    bool MasterIsMuted;

    float MusicVolume;
    public Slider MusicVolumeSlider;
    public Toggle MusicMuteToggle;
    bool MusicIsMuted;

    float SFXVolume;
    public Slider SFXVolumeSlider;
    public Toggle SFXMuteToggle;
    bool SFXIsMuted;
    #endregion

    private void Start()
    {
        #region SoundSettings (InStart)
        MasterIsMuted = (PlayerPrefs.GetInt("MasterIsMuted") != 0);
        MasterVolume = PlayerPrefs.GetFloat("MasterVolume", 0);
        AudioMixer.SetFloat("MasterVolume", MasterVolume);
        if (MasterIsMuted == true)
        { AudioMixer.SetFloat("MasterVolume", -80f); }
        MasterVolumeSlider.value = MasterVolume;
        MasterMuteToggle.isOn = MasterIsMuted;

        MusicIsMuted = (PlayerPrefs.GetInt("MusicIsMuted") != 0);
        MusicVolume = PlayerPrefs.GetFloat("MusicVolume", 0);
        AudioMixer.SetFloat("MusicVolume", MusicVolume);
        if (MusicIsMuted == true)
        { AudioMixer.SetFloat("MusicVolume", -80f); }
        MusicVolumeSlider.value = MusicVolume;
        MusicMuteToggle.isOn = MusicIsMuted;

        SFXIsMuted = (PlayerPrefs.GetInt("SFXIsMuted") != 0);
        SFXVolume = PlayerPrefs.GetFloat("SFXVolume", 0);
        AudioMixer.SetFloat("SFXVolume", SFXVolume);
        if (SFXIsMuted == true)
        { AudioMixer.SetFloat("MusicVolume", -80f); }
        SFXVolumeSlider.value = SFXVolume;
        SFXMuteToggle.isOn = SFXIsMuted;

        #endregion

        #region VideoSettings (InStart)
        IsFullscreen = (PlayerPrefs.GetInt("isFullscreen") != 0);
        FullscreenToggle.isOn = IsFullscreen;

        int CurrentResolutionIndex = 0;
        Resolutions = Screen.resolutions;

        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i<Resolutions.Length; i++)
        {
            string Option = Resolutions[i].width + "x" + Resolutions[i].height;
            options.Add(Option);

            if (Resolutions[i].width == Screen.currentResolution.width &&
                Resolutions[i].height == Screen.currentResolution.height)
            {
                CurrentResolutionIndex = i;
            }
        }

        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = CurrentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();
        #endregion
    }

    #region VideoSettings
    public void SetResolution(int ResolutionIndex)
    {
        Resolution resolution = Resolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        //Debug.Log(resolution.width.ToString() + " by " + resolution.height.ToString());
    }
    
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("isFullscreen", (isFullscreen ? 1 : 0));
        Debug.Log("isFullscreen = " + isFullscreen);
    }
    #endregion

    #region SoundSettings
    public void SetMasterMute(bool MasterMute)
    {
        MasterIsMuted = MasterMute;
        PlayerPrefs.SetInt("MasterIsMuted", (MasterIsMuted ? 1 : 0));
        if (MasterIsMuted == true)
        {
            AudioMixer.SetFloat("MasterVolume", -80f);
        }
        else
        {
            AudioMixer.SetFloat("MasterVolume", MasterVolume);
        }
    }

    public void SetMasterVolume(float Volume)
    {
        MasterVolume = Volume;
        PlayerPrefs.SetFloat("MasterVolume", MasterVolume);
        AudioMixer.SetFloat("MasterVolume", MasterVolume);
        if (MasterIsMuted == true)
        {
            AudioMixer.SetFloat("MasterVolume", -80f);
        }
    }

    public void SetMusicMute(bool MusicMute)
    {
        MusicIsMuted = MusicMute;
        PlayerPrefs.SetInt("MusicIsMuted", (MusicIsMuted ? 1 : 0));
        if (MusicIsMuted == true)
        {
            AudioMixer.SetFloat("MusicVolume", -80f);
        }
        else
        {
            AudioMixer.SetFloat("MusicVolume", MusicVolume);
        }
    }

    public void SetMusicVolume(float Volume)
    {
        MusicVolume = Volume;
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume);
        AudioMixer.SetFloat("MusicVolume", MusicVolume);
        if (MusicIsMuted == true)
        {
            AudioMixer.SetFloat("MusicVolume", -80f);
        }
    }

    public void SetSFXMute(bool SFXMute)
    {
        SFXIsMuted = SFXMute;
        PlayerPrefs.SetInt("SFXIsMuted", (SFXIsMuted ? 1 : 0));
        if (SFXIsMuted == true)
        {
            AudioMixer.SetFloat("SFXVolume", -80f);
        }
        else
        {
            AudioMixer.SetFloat("SFXVolume", SFXVolume);
        }
    }

    public void SetSFXVolume(float Volume)
    {
        SFXVolume = Volume;
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume);
        AudioMixer.SetFloat("SFXVolume", SFXVolume);
        if (SFXIsMuted == true)
        {
            AudioMixer.SetFloat("SFXVolume", -80f);
        }
    }
    #endregion
}
