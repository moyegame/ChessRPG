using HFrameWork.Manager;
using UnityEngine;

public class SoundManager : ManagerBase
{
    public override void Init()
    {
        GameObject go = new GameObject("AudioSource");
        GameObject.DontDestroyOnLoad(go);

        for (int index = 0; index < Config.AUDIO_SOURCE_POOL_NUM; index++)
        {
            AudioSource Player = new GameObject("Player" + (index +1)).AddComponent<AudioSource>();
            Player.transform.SetParent(go.transform,false);
        }
    }
    
    
}
