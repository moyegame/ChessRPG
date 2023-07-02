using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Entry : MonoBehaviour
{
    public string FirstSceneName;
    private void Awake()
    {
        GameManager.__Launch__();
    }

    private async UniTask Start()
    {
        GameManager.SceneMgr.LoadScene(FirstSceneName);
    }
}