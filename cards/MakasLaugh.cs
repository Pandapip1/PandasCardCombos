using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class MakasLaugh : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Maka's Laugh";
        }

        protected override string GetDescription()
        {
            return "He he he he he";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Scarce");
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
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
                    GetCardInfoByName("Sneaky"),
                    5
                },
                {
                    GetCardInfoByName("Mayhem"),
                    2
                },
                {
                    GetCardInfoByName("TargetBounce"),
                    1
                }
            };
        }
    }
}
