using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class Worg : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Worg";
        }

        protected override string GetDescription()
        {
            return "Worgn't you like to comboe?";
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]{
                new CardInfoStat
                {
                    stat = "1",
                    amount = "Amsazing Comebo!!1!!",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Legendary");
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
                    GetCardInfoByName("Remote"),
                    5
                },
                {
                    GetCardInfoByName("DrillAmmo"),
                    5
                },
                {
                    GetCardInfoByName("Grow"),
                    5
                }
            };
        }
    }
}
