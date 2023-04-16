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
            CustomCard.BuildCard<Cards.PhunixsInbox>((card) => {
                // Save the CardInfo instance for later use
                Cards.PhunixsInbox.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.BigSibling>((card) => {
                // Save the CardInfo instance for later use
                Cards.BigSibling.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.BouncingBetties>((card) => {
                // Save the CardInfo instance for later use
                Cards.BouncingBetties.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.BulletproofPlan>((card) => {
                // Save the CardInfo instance for later use
                Cards.BulletproofPlan.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.CosmicRays>((card) => {
                // Save the CardInfo instance for later use
                Cards.CosmicRays.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.LittleSibling>((card) => {
                // Save the CardInfo instance for later use
                Cards.LittleSibling.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.Police>((card) => {
                // Save the CardInfo instance for later use
                Cards.Police.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.Politician>((card) => {
                // Save the CardInfo instance for later use
                Cards.Politician.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.Pyromaniac>((card) => {
                // Save the CardInfo instance for later use
                Cards.Pyromaniac.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.RushHourTraffic>((card) => {
                // Save the CardInfo instance for later use
                Cards.RushHourTraffic.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.SilentButDeadly>((card) => {
                // Save the CardInfo instance for later use
                Cards.SilentButDeadly.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.InstaReload>((card) => {
                // Save the CardInfo instance for later use
                Cards.InstaReload.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.OhDeer>((card) => {
                // Save the CardInfo instance for later use
                Cards.OhDeer.cardInfoInstance = card;
            });
            CustomCard.BuildCard<Cards.PhunixSandwich>((card) => {
                // Save the CardInfo instance for later use
                Cards.PhunixSandwich.cardInfoInstance = card;
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
