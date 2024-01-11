using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class appear : MonoBehaviour
{
    public int isappear = 0;
    private SpriteRenderer spr;
    public GameObject robot;
    private movement moveScript;
    public AudioClip winSound;
    private AudioSource audioSource;
    
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.enabled = false;

        

        moveScript = robot.GetComponent<movement>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        isappear = moveScript.win;
        if ( isappear == 1)
        {
            if (audioSource.clip == null)
            {
                audioSource.clip = winSound;
                audioSource.Play();
                spr.enabled = true;

                StreamReader inp_stm = new StreamReader(Application.persistentDataPath + "/LevelState.txt");
                int currentScene = int.Parse(SceneManager.GetActiveScene().name.Replace("lv", ""));
                string inp_ln = inp_stm.ReadLine();
                inp_ln = inp_ln.Replace("Lv"+(currentScene+1)+":l", "Lv" + (currentScene+1) + ":ul");
                Debug.Log("Lv" + currentScene + ":ul");
                inp_stm.Close();
                File.WriteAllText(Application.persistentDataPath + "/LevelState.txt", inp_ln);
            }
            
        }

        if (isappear == 0)
        {
            spr.enabled = false;
        }

    }
}
