using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : Singleton<Managers>
{
    private ResourceManager resource;
    private PoolManager pool;
    private UIManager ui;
    private CoroutineManager routine;
    private ScreenManager screen;

    public static ResourceManager Resource { get { return Instance?.resource; } }
    public static PoolManager Pool { get { return Instance?.pool; } }
    public static UIManager UI { get { return Instance?.ui; } }
    public static CoroutineManager Routine { get { return Instance?.routine; } }
    public static ScreenManager Screen { get { return Instance?.screen; } }


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    public static void GameStart()
    {
        Managers.Resource.Load<GameSettingsProfile>("");
    }
}
