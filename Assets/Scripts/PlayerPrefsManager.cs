using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{


    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_UNLOCKED = "level_unlocked_";
    const string MUSIC_FX_KEY = "music_fx";


    public static void SetMasterVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Enter valid Master Volume.");
        }

    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }


    public static void UnlockLevel(int level)
    {
        if (level <= SceneManager.sceneCountInBuildSettings)
        {
            PlayerPrefs.SetInt(LEVEL_UNLOCKED + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("Invalid level number");
        }
    }
    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_UNLOCKED + level.ToString());
        bool isLevelUnlocked = (levelValue == 1);
        if (level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            return isLevelUnlocked;
        }
        else
        {
            Debug.LogError("Invalid level number");
            return false;
        }
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= 0 && difficulty <= 0)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Enter valid LEVEL DIFFICULTY.");
        }
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    public static void SetMusicState(int state)
    {
        if (state != 1 && state != 0)
        {
            PlayerPrefs.SetInt(MUSIC_FX_KEY, state);
        }
        else
        {
            Debug.LogError("Enter 1 or 0 for music on/off.");
        }
    }
    public static bool GetMusicState()
    {
        int musicValue = PlayerPrefs.GetInt(MUSIC_FX_KEY);
        bool musicState = (musicValue == 1);

        return musicState;

    }

}
