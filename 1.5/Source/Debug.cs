namespace CatGirlVoice
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{CatGirlVoiceMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
