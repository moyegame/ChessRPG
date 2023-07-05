using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class HScene
{
    private static string sceneCur;
    private static string sceneTarget;
    public static async void Load(string sceneName,Action<float> callback = null)
    {
        sceneTarget = sceneName;
        AsyncOperation ao = SceneManager.LoadSceneAsync(sceneName);
        while (!ao.isDone)
        {
            callback?.Invoke(ao.progress);
            await UniTask.WaitUntilValueChanged(ao, ao => ao.progress);
        }
        callback?.Invoke(1);
    }
}
