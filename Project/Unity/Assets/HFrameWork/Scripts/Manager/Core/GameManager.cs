using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HFrameWork.Manager;
using UnityEngine;

public static class GameManager
{
    public static SceneManager SceneMgr;
    public static LogManager LogMgr;
    public static SoundManager SoundMgr;
    
    public static void __Launch__()
    {
        Register(SceneMgr);
        Register(LogMgr);
        Register(SoundMgr);
    }

    private static void Register<T>(T t) where T : ManagerBase, new()
    {
        t = new T();

        t.Init();
    }
}
