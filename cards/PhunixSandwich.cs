using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class PhunixSandwich : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Phunix Sandwich";
        }

        protected override string GetDescription()
        {
            return "Nom nom tasty bird";
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
                    GetCardInfoByName("Phoenix"),
                    1
                },
                {
                    OhDeer.cardInfoInstance,
                    1
                },
                {
                    InstaReload.cardInfoInstance,
                    1
                },
                {
                    PhunixsInbox.cardInfoInstance,
                    1
                }
            };
        }
    }
}
