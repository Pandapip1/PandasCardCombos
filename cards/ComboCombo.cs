using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class ComboCombo : BaseCombo
    {
        protected override string GetTitle()
        {
            return "The Combo Combo";
        }

        protected override string GetDescription()
        {
            return "This will probably crash your game.";
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]{
                new CardInfoStat
                {
                    stat = "Every",
                    amount = "Combo",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.aLotOf
                }
            };
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Divine");
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
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
            var allCardInfos = new CardInfo[]{
                AirTrafficController.cardInfoInstance,
                BigSibling.cardInfoInstance,
                BouncingBetties.cardInfoInstance,
                BulletproofPlan.cardInfoInstance,
                CosmicRays.cardInfoInstance,
                InstaReload.cardInfoInstance,
                Karen.cardInfoInstance,
                LittleSibling.cardInfoInstance,
                MakasLaugh.cardInfoInstance,
                OhDeer.cardInfoInstance,
                PhunixSandwich.cardInfoInstance,
                PhunixsInbox.cardInfoInstance,
                Police.cardInfoInstance,
                Politician.cardInfoInstance,
                Pyromaniac.cardInfoInstance,
                RushHourTraffic.cardInfoInstance,
                SilentButDeadly.cardInfoInstance,
                VanillaCombo.cardInfoInstance,
                Worg.cardInfoInstance,
            };
            var combo = new Dictionary<CardInfo, int>();
            foreach (var card in allCardInfos)
            {
                combo.Add(card, 1);
            }
            return combo;
        }
    }
}
