using System.Collections.Generic;
using UnityEngine;

namespace AkatsukiMuckCheat
{
    public class Loader
    {
        private static readonly GameObject gObj = new GameObject();

        public static void Load()
        {
            gObj.AddComponent<MainHack>();
            Object.DontDestroyOnLoad(gObj);
        }

        public static void Unload()
        {
            Object.Destroy(gObj);
        }
    }
}