using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerManager : MonoBehaviour
{
    private AudioManager audioManager;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;


    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        AddHoverSoundEventToButton1(button1);
        AddHoverSoundEventToButton2(button2);
        AddHoverSoundEventToButton3(button3);
    }

    private void AddHoverSoundEventToButton1(GameObject go)
    {
        if (go.GetComponent<EventTrigger>() == null)
        {
            go.GetComponent<EventTrigger>();
        }

        EventTrigger trigger = go.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener((functionNeeded) => { audioManager.PlayAudioUIHover(); });
        trigger.triggers.Add(entry);
    }

    private void AddHoverSoundEventToButton2(GameObject go)
    {
        if (go.GetComponent<EventTrigger>() == null)
        {
            go.GetComponent<EventTrigger>();
        }

        EventTrigger trigger = go.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;

        // Add the function needed to play the sound from Audio Manager.
        entry.callback.AddListener((functionNeeded) => { audioManager.PlayAudioUIHover(); });
        trigger.triggers.Add(entry);
    }

    private void AddHoverSoundEventToButton3(GameObject go)
    {
        if (go.GetComponent<EventTrigger>() == null)
        {
            go.GetComponent<EventTrigger>();
        }

        EventTrigger trigger = go.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener((functionNeeded) => { audioManager.PlayAudioUIHover(); });
        trigger.triggers.Add(entry);

        if (go.name == "TryAgainButton")
        {
            Destroy(go);
        }
    }
}
