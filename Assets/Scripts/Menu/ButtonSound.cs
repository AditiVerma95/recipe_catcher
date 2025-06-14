using UnityEngine;

public class ButtonSound : MonoBehaviour {
    public AudioSource audioSource;
    [SerializeField] private AudioClip buttonClickAudio;
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    public void ButtonSoundClip() {
        audioSource.resource = buttonClickAudio;
    }
}
