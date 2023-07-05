using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public static class HDebug
{
    [Conditional("DEBUG")]
    public static void Log(string str)
    {
        Debug.Log(str);
    }
}
