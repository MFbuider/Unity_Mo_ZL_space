using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SavesettingData : MonoBehaviour
{
    string Path;
    public Text TestText;
    FileStream file;

    void Awake()
    {
        //文字檔案路徑，Application.persistentDataPath使用此方法可以直接將資料進行讀寫，無需再進行轉檔處理
        Path = Application.persistentDataPath + "Save.txt";
        Debug.Log(Path);
        //檢查此路徑是否有Save.txt檔案了，如果有會回傳true，否則回傳false
        if (File.Exists(Path))
        {
            //  TestText.text = "在手機已經建立過一個Save檔案";
        }
        else
        {
            // TestText.text = "在手機上尚未建立Save檔案，正在建立...";
            //在此路徑下建立一個文字檔，檔名為Save
            file = new FileStream(Path, FileMode.Create);
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
