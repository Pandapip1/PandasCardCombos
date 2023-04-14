using BepInEx;
using UnboundLib.Cards;
using UnboundLib;
using BepInEx.Logging;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine.UI;
using UnboundLib.Utils.UI;
using UnityEngine;
using Photon.Pun;
using UnboundLib.Networking;

namespace PandasCardCombos
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInPlugin(pluginId, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Rounds.exe")]
    public class Plugin : BaseUnityPlugin
    {
        public const string pluginId = "com.pandapip1.rounds.pandascardcombos";
        public static Plugin instance;
        public static new ManualLogSource Logger => Plugin.instance.GetLogger();
        
        private void Awake()
        {
            instance = this;

            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            // Load credits
            Unbound.RegisterCredits("Panda's Card Combos", new string[] { "Pandapip1 (@Pandapip1)" }, "Pandapip1.com", "https://pandapip1.com/");

            // Load custom cards
            CustomCard.BuildCard<Cards.AirTrafficController>((card) => {
                // Save the CardInfo instance for later use
                Cards.AirTrafficController.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.Karen>((card) => {
                // Save the CardInfo instance for later use
                Cards.Karen.cardInfoInstance = card;
            }); 

            // Harmony patching: all patches in the same assembly as this class will be applied
            Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }

        internal ManualLogSource GetLogger()
        {
            return base.Logger;
        }
    }
}
