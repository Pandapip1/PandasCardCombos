using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class RushHourTraffic : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Rush Hour Traffic";
        }

        protected override string GetDescription()
        {
            return "Traffic? Just speed up time!";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Epic");
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
            return new Dictionary<CardInfo, int>()
            {
                {
                    GetCardInfoByName("Fast forward"),
                    1
                },
                {
                    GetCardInfoByName("Teleport"),
                    1
                },
            };
        }
    }
}
