using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioMenu : MonoBehaviour
{

    public sound[] sounds;

    public static AudioMenu instance;

    // Start is called before the first frame update
    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 0)
        {
            FindObjectOfType<AudioManager>().Play("menu");
            FindObjectOfType<AudioManager>().Stop("Theme");

            FindObjectOfType<AudioManager>().Stop("Credits");

        }
        else
        {
            if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                FindObjectOfType<AudioManager>().Stop("menu");
                FindObjectOfType<AudioManager>().Stop("Theme");
                FindObjectOfType<AudioManager>().Play("Credits");
                

            }
            else
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    FindObjectOfType<AudioManager>().Stop("menu");
                    FindObjectOfType<AudioManager>().Stop("Credits");
                    FindObjectOfType<AudioManager>().Play("Theme");

                   
                }
            }
        }
        

    }


    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        
      
        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
            
    }
}
