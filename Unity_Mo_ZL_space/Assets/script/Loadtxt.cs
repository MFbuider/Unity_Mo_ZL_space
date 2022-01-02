using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class Loadtxt : MonoBehaviour
{
    [Header("讀取中文文宇檔案")]
    public string CHMassage;
    [Header("讀取英文文字檔案")]
    public string ENMassage;
//中文文宇檔的路徑
string CHPath;
    //英文文字檔的路徑
    string ENPath;
    public string[] CHTexts;
    public string[] ENTexts;
    public int TextID;

    void Awake()
    {
        //中文文字檔在StreamingAssets資料的路径
        CHPath= Application.streamingAssetsPath + "/CH.txt";
        //讀取中文文字檔內所有的文守
        CHMassage = File.ReadAllText(CHPath);
        //en文字檔在StreamingAssets資料的路径
        ENPath= Application.streamingAssetsPath + "/EN.txt";
        //讀取中文文字檔內所有的
        ENMassage = File.ReadAllText(ENPath);
        //Debug.Log(CHMassage);  
        //Debug.Log(ENMassage);
        CHTexts = CHMassage.Split('\n');
        ENTexts = ENMassage.Split('\n');

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menu.LanguagelD == 1)
        {
            GetComponent<Text>().text = CHTexts[TextID];
        }
        if (menu.LanguagelD == 0)
        {
            GetComponent<Text>().text = ENTexts[TextID];
        }

    }
}
