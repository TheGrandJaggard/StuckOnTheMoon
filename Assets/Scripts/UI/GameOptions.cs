using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class GameOptions : MonoBehaviour
{
    private int WhichGunToUse;
    public GameObject Arm;

    public AudioMixer AudioMixer;
    float MasterVolume;
    bool MasterIsMuted;
    float MusicVolume;
    bool MusicIsMuted;
    float SFXVolume;
    bool SFXIsMuted;



    void Start()
    {
        #region SoundSettingsLoader
        MasterIsMuted = (PlayerPrefs.GetInt("MasterIsMuted") != 0);
        MasterVolume = PlayerPrefs.GetFloat("MasterVolume", 0);
        AudioMixer.SetFloat("MasterVolume", MasterVolume);
        if (MasterIsMuted == true)
        { AudioMixer.SetFloat("MasterVolume", -80f); }

        MusicIsMuted = (PlayerPrefs.GetInt("MusicIsMuted") != 0);
        MusicVolume = PlayerPrefs.GetFloat("MusicVolume", 0);
        AudioMixer.SetFloat("MusicVolume", MusicVolume);
        if (MusicIsMuted == true)
        { AudioMixer.SetFloat("MusicVolume", -80f); }

        SFXIsMuted = (PlayerPrefs.GetInt("SFXIsMuted") != 0);
        SFXVolume = PlayerPrefs.GetFloat("SFXVolume", 0);
        AudioMixer.SetFloat("SFXVolume", SFXVolume);
        if (SFXIsMuted == true)
        { AudioMixer.SetFloat("MusicVolume", -80f); }
        #endregion

        #region GunSettings
        WhichGunToUse = PlayerPrefs.GetInt("WhichGunToUse");
        PanelController PanelController = Arm.GetComponent<PanelController>();
        PanelController.SetActivePanel(WhichGunToUse);
        #endregion
    }

    public void SetWhichGunToUse(int WhichGunToSet)
    {
        WhichGunToUse = WhichGunToSet;
        PlayerPrefs.SetInt("WhichGunToUse", WhichGunToUse);
        PanelController PanelController = Arm.GetComponent<PanelController>();
        PanelController.SetActivePanel(WhichGunToUse);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("StartingScene");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
