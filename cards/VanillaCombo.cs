using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class VanillaCombo : BaseCombo
    {
        protected override string GetTitle()
        {
            return "The Ultimate Vanilla Combo";
        }

        protected override string GetDescription()
        {
            return "What could go wrong?";
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]{
                new CardInfoStat
                {
                    stat = "Literally",
                    amount = "Everything",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.aLotOf
                }
            };
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Legendary");
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.NatureBrown;
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override string[] GetDependencies()
        {
            return new string[] { };
        }

        protected override Dictionary<CardInfo, int> GetCombo()
        {
            var allCards = new string[]{
                "AbyssalCountdown",
                "Barrage",
                "Big Bullet",
                "BombsAway",
                "Bouncy",
                "Brawler",
                "Buckshot",
                "Burst",
                "Careful planning",
                "Chase",
                "ChillingPresence",
                "Cold bullets",
                "Combine",
                "Dazzle",
                "Decay",
                "Defender",
                "Demonic pact",
                "DrillAmmo",
                "Echo",
                "EMP",
                "Empower",
                "Explosive bullet",
                "Fast ball",
                "Fast forward",
                "Frost slam",
                "Glasscannon",
                "Grow",
                "Healing field",
                "Homing",
                "HUGE",
                "Implode",
                "Leach",
                "Lifestealer",
                "Mayhem",
                "Overpower",
                "Parasite",
                "Phoenix",
                "Poison bullets",
                "Pristine perseverence",
                "Quick Reload",
                "Quick Shot",
                "RadarShot",
                "Radiance",
                "Refresh",
                "Remote",
                "Riccochet",
                "Saw",
                "Scavenger",
                "Shield Charge",
                "Shields up",
                "Shockwave",
                "Silence",
                "Sneaky bullets",
                "SPRAY",
                "Static field",
                "Steady shot",
                "Supernova",
                "Tactical reload",
                "Tank",
                "TargetBounce",
                "TasteOfBlood",
                "Teleport",
                "Thruster",
                "Timed detonation",
                "Toxic cloud",
                "Trickster",
                "Wind up"
            };
            var combo = new Dictionary<CardInfo, int>();
            foreach (var card in allCards)
            {
                combo.Add(GetCardInfoByName(card), 1);
            }
            return combo;
        }
    }
}
