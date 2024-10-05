using HarmonyLib;
using Verse;

namespace CatGirlVoice
{
    public class CatGirlVoiceMod : Mod
    {
        public const string PACKAGE_ID = "catgirlvoice.1trickPwnyta";
        public const string PACKAGE_NAME = "Cat Girl Voice";

        public CatGirlVoiceMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
