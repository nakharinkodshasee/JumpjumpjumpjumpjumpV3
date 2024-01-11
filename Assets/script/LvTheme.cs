using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvTheme : MonoBehaviour
{

    public AudioClip[] audioClips;
    private AudioSource audioSource;
    private int currentScene;
    private GameObject instance;
    private bool sceneIsLoaded = true;

    void Awake()
    {
        instance = GameObject.Find("AudioManager");
        if (instance != null && instance!= this.gameObject) {
            Destroy(this.gameObject);
        }
            ;
        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Update()
    {
        if (sceneIsLoaded == true)
        {   
            if(SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "LevelSelect")
            {
                currentScene = 0;
            }
            else
            {
                currentScene = int.Parse(SceneManager.GetActiveScene().name.Replace("lv", ""));
            }
                        if (currentScene > 0 && currentScene < 11)
                        {
                            DontDestroyOnLoad(this.gameObject);
                                if (audioSource.clip.name != audioClips[0].name)
                                {
                                    audioSource.clip = audioClips[0];
                                    audioSource.Play();
                                }
                                audioSource.clip = audioClips[0];
                        }
                        else if(currentScene > 10 && currentScene < 16)
                        {
                            DontDestroyOnLoad(this.gameObject);
                            if(audioSource.clip.name != audioClips[1].name)
                                    {
                                        audioSource.clip = audioClips[1];
                                        audioSource.Play();
                                    }
                            
                        }
                        else if (currentScene > 15 && currentScene < 21)
                        {
                            DontDestroyOnLoad(this.gameObject);
                            if (audioSource.clip.name != audioClips[2].name)
                            {
                                audioSource.clip = audioClips[2];
                                audioSource.Play();
                            }
                        }
                        else {
                            Destroy(this.gameObject);
                        }
            sceneIsLoaded = false;
        }
    }

    void sceneIsLoad()
    {
        sceneIsLoaded = true;
        Time.timeScale = 1;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        sceneIsLoad();
    }
}
