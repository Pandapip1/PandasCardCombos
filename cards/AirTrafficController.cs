using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public class AirTrafficController : BaseCombo
    {
        protected override string GetTitle()
        {
            return "Air Traffic Controller";
        }

        protected override string GetDescription()
        {
            return "";
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
                    GetCardInfoByName("RadarShot"),
                    3
                },
                {
                    GetCardInfoByName("Echo"),
                    1
                },
                {
                    GetCardInfoByName("Fast forward"),
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
