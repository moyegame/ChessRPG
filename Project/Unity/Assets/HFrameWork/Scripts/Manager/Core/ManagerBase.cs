public abstract class ManagerBase
{
    public string Name => GetType().Name;

    public ManagerBase Ins;
    public abstract void Init();
}
