using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class PhunixsInbox : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Phunix's Business Email";
        }

        protected override string GetDescription()
        {
            return "Hi Phunix, I made a mod that allows you...";
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
                    GetCardInfoByName("Careful planning"),
                    2
                },
                {
                    GetCardInfoByName("Silence"),
                    1
                }
            };
        }
    }
}
