using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace HFrameWork.Manager
{
    public class SceneManager : ManagerBase
    {
        public override void Init()
        {
            curSceneName = targetSceneName = string.Empty;
        }
        
        /// <summary>
        /// 当前的场景名字
        /// </summary>
        private string curSceneName;
        
        /// <summary>
        /// 加载中的目标场景名字
        /// </summary>
        private string targetSceneName;
        
        /// <summary>
        /// 场景加载
        /// </summary>
        /// <param name="sceneName"></param>
        /// <param name="LoadProgress"></param>
        public async UniTask LoadScene(string sceneName,Action<float> LoadProgress = null)
        {
            targetSceneName = sceneName;

            AsyncOperation ao = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
            while (!ao.isDone)
            {
                LoadProgress?.Invoke(ao.progress);
                await UniTask.Delay(10);
            }
            LoadProgress?.Invoke(ao.progress);
            
            curSceneName = targetSceneName;
            targetSceneName = string.Empty;
        }
    }
}
