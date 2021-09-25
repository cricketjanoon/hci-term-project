using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioClip[] musicList;
    private AudioSource audioSource;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        //check for the clip to present
        if (musicList[level])
        {
            audioSource.clip = musicList[level];
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

   
}
