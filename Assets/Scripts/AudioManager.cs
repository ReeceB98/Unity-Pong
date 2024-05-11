using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip blip;
    [SerializeField] private AudioClip goal;
    [SerializeField] private AudioClip uiSelector;
    [SerializeField] private AudioSource audioSource;

    private static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayAudioBlip()
    {
        audioSource.clip = blip;
        audioSource.Play();
    }

    public void PlayAudioGoal()
    {
        audioSource.clip = goal;
        audioSource.Play();
    }
    public void PlayAudioUISelector()
    {
        audioSource.clip = uiSelector;
        audioSource.Play();
    }
}
