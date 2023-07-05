using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entry : MonoBehaviour
{
    private void Awake()
    {
        HScene.Load(SceneName.Scene_Init, (p) =>
        {
            Debug.Log("加载进度 : " + p);
        });
    }
}
