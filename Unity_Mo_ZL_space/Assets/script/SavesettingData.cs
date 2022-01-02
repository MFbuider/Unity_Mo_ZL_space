using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavesettingData : MonoBehaviour
{
    string path;
    public Text TestText;
    FillStream file;

    private void Awake()
    {
        path = Application.persistenDataPath + "Save.txt";
        Debug.Log(path);

        if (File.Exists(Path))
        {
            TestText.text = "在手機建立過一個Save檔案";
        }
        else
        {
            TestText.text = "在手機尚未建立Save檔案，正在建立";
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
