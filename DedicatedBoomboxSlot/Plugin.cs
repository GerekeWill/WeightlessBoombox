using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DedicatedBoomboxSlot
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "KurisuBot.DedicatedBoomboxSlot";
        private const string modName = "DedicatedBoomboxSlot";
        private const string modVersion = "1.0.0";
        public static Plugin instance;
        private readonly Harmony harmony = new Harmony(modGUID);

        internal ManualLogSource mls;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("DedicatedBoomboxSlot Loading . . . ");

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);


            mls.LogInfo("DedicatedBoomboxSlot Loaded!");
        }

        public static void Log(string message)
        {
             Plugin.instance.Logger.LogInfo(message);
        }
    }
}
