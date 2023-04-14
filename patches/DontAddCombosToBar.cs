using HarmonyLib;
using UnboundLib.Cards;

namespace PandasCardCombos.Patch
{
    [HarmonyPatch(typeof(CardBar), nameof(CardBar.AddCard))]
    public static class DontAddCombosToBar
    {
        [HarmonyAfter("com.willis.rounds.unbound")]
        public static bool Prefix(CardInfo card)
        {
            var customCard = card.GetComponent<CustomCard>();
            return customCard == null || !(customCard is Cards.BaseCombo);
        }
    }
}
