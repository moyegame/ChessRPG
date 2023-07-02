using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class LogManager : ManagerBase
{
    public override void Init()
    {
        
    }

    [Conditional("DEBUG")]
    public void LogYellow(object obj)
    {
        Debug.Log(obj.ToString());
    }

}
