﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
    
{
    public string Name;
    // Start is called before the first frame update
    void Awake()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextSence()
    {
        Application.LoadLevel(Name);
    }
    void Quit()
    {
        Application.Quit();
    }

}
