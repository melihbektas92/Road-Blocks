
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music instance = null;
    private AudioSource music;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
    }

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
    }
}
