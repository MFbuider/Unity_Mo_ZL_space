using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menw : MonoBehaviour
{
   /* public class Menu : MonoBehaviour
    {
        [Header("擺放BGM的Prefab物件")]
        public GameObject BGM;

        [Header("控制聲音開關")]
        public bool ControlSound;
        [Header("開聲音的圖片")]
        public Sprite OpenSoundTex;
        [Header("關聲音的圖片")]
        public Sprite CloseSoundTex;
        [Header("放入聲音的按鈕")]
        public Image SoundButton;*/

        [Header("控制解析度的下拉選單")]
        public Dropdown ScreenSizeDropdown;
        // Start is called before the first frame update
        void Start()
        {
            //BGM => 背景音樂
            //GameObject.Find("物件名稱")
            //GameObject.FindWithTag("物件標籤")
            //找尋場景上是否有BGM物件，如果找尋BGM數量為0，代表場上沒有任何BGM物件
           /* if (GameObject.FindGameObjectsWithTag("BGM").Length <= 0)
            {
                //Instantiate動態生成(要生成的物件)
                Instantiate(BGM);
            }*/

        }
        // Start is called before the first frame update
        public dropdown ScreenSizeDropdown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {

    }

    
    /* public void SoundControl()
    {

        ControlSound = !ControlSound;
        if (ControlSound)
        {
            AudioListener.pause = true;
            SoundButton.sprite = Resources.Load<Sprite>("pause-icon");

        }
        else
        {
            AudioListener.pause = false;
            SoundButton.sprite = Resources.Load<Sprite>("voice Button");
        }

    } 
    */


    public void ChangeScreenSize()
    {
        if (ScreenSizeDropdown.value == 0)
        {
            Screen.SetResolution(1080, 1920, false);
        }
        else
        {
            Screen.SetResolution(480, 800, false);
        }
    }
}
