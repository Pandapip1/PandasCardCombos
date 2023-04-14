using UnboundLib.Cards;
using UnityEngine;
using System.Collections.Generic;
using Photon.Pun;
using UnboundLib;

namespace PandasCardCombos.Cards
{
    public abstract class BaseCombo : CustomCard
    {
        public static CardInfo cardInfoInstance = null;

        protected abstract string[] GetDependencies();

        protected abstract Dictionary<CardInfo, int> GetCombo();

        protected override CardInfoStat[] GetStats()
        {
            var res = new List<CardInfoStat>();
            var combo = GetCombo();
            foreach (var card in combo)
            {
                if (card.Key == null)
                {
                    continue;
                }
                var formattedTitle = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(card.Key.cardName.ToLower());
                CardInfoStat.SimpleAmount simepleAmount = CardInfoStat.SimpleAmount.notAssigned;
                if (card.Value >= 3)
                {
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf;
                } else if (card.Value >= 2)
                {
                    simepleAmount = CardInfoStat.SimpleAmount.aLotOf;
                } else if (card.Value >= 1)
                {
                    simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf;
                }
                res.Add(new CardInfoStat
                {
                    stat = formattedTitle,
                    amount = card.Value.ToString(),
                    positive = true,
                    simepleAmount = simepleAmount
                });
            }
            return res.ToArray();
        }

        public override string GetModName()
        {
            return "PCC";
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo ammo, CharacterData character, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers stats)
        {
            var combo = GetCombo();
            foreach (var card in combo)
            {
                for (int i = 0; i < card.Value; i++)
                {
                    if (i == 0)
                    {
                        ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, card.Key, false, "", 0, 0, true);
                    } else
                    {
                        Plugin.instance.ExecuteAfterFrames(i, () =>
                        {
                            ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, card.Key, false, "", 0, 0, true);
                        });
                    }
                }
            }
        }

        public static CardInfo GetCardInfoByName(string name)
        {
            var cards = CardChoice.instance.cards;
            foreach (var card in cards)
            {
                if (card.name == name)
                {
                    Plugin.Logger.LogDebug("Found card " + card.name + " with name " + card.cardName);
                    return card;
                }
                Plugin.Logger.LogDebug("Card " + card.name + " has name " + card.cardName);
            }
            Plugin.Logger.LogError("Could not find card with name " + name);
            return null;
        }
    }
}
