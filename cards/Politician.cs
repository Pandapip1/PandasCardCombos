using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class Politician : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Politician";
        }

        protected override string GetDescription()
        {
            return "";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityLib.Utils.RarityUtils.GetRarity("Rare");
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
                    GetCardInfoByName("Trickster"),
                    1
                },
                {
                    GetCardInfoByName("Parasite"),
                    1
                },
                {
                    GetCardInfoByName("Riccochet"),
                    1
                },
                {
                    GetCardInfoByName("Careful planning"),
                    1
                }
            };
        }
    }
}
