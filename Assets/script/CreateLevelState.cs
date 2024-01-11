using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreateLevelState : MonoBehaviour
{

    void Start()
    {
        if (!File.Exists(Application.persistentDataPath + "/LevelState.txt"))
        {
            File.WriteAllText(Application.persistentDataPath + "/LevelState.txt", "Lv1:ulLv2:lLv3:lLv4:lLv5:lLv6:lLv7:lLv8:lLv9:lLv10:lLv11:lLv12:lLv13:lLv14:lLv15:lLv16:lLv17:lLv18:lLv19:lLv20:l");
        }
        else
        {
            Debug.Log("LevelStatealreadyexist");
        }
    }

}
