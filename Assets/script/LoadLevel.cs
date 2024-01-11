using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    public Sprite[] sprites;
    [SerializeField] private  int level;
    private Image image;
    private Button button;
    [SerializeField] private GameObject buttonObject;

    void Start()
    {
        image = GetComponent<Image>();
        button = buttonObject.GetComponent<Button>();
        StreamReader inp_stm = new StreamReader(Application.persistentDataPath + "/LevelState.txt");

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            if (inp_ln.Contains("Lv"+level+":l"))
            {
                image.sprite = sprites[1];
                button.interactable = false;
            }
        }

        inp_stm.Close();
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("lv"+level);
    }
}
