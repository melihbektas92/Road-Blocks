
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
        else
        {
            instance = this;
            GameObject.Destroy(gameObject);
        }
    }

    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Play();
    }
}
