using UnityEngine;
using UnityEngine.UI;

public class SettingMenuManager : MonoBehaviour
{

    public Slider volumeSlider;
    //public LevelManager levelManager;

    private MusicManager musicManger;

    // Use this for initialization
    void Start()
    {
        musicManger = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        musicManger.SetVolume(volumeSlider.value);
    }


    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);


    }



}
