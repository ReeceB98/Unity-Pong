using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerManager : MonoBehaviour
{
    private AudioManager audioManager;

    [Header("Equipped Trigger Buttons")]
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;
    [Space]
    [Header("GameObjects to Destroy")]
    [SerializeField] private string destroyObject1;



    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        AddHoverSoundEventToButton1(button1);
        AddHoverSoundEventToButton2(button2);
        AddHoverSoundEventToButton3(button3);
        AddHoverSoundEventToButton4(button4);
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
    }

    private void AddHoverSoundEventToButton4(GameObject go)
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

        if (go.name == destroyObject1)
        {
            Destroy(go);
        }
    }
}
