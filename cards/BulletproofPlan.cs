using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class BulletproofPlan : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Bulletproof Plan";
        }

        protected override string GetDescription()
        {
            return "What do you mean it's a bulletproof plan? Oh... I see.";
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
                    GetCardInfoByName("Defender"),
                    3
                },
                {
                    GetCardInfoByName("Careful planning"),
                    1
                }
            };
        }
    }
}
