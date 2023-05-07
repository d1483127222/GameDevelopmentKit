using GameFramework;
using GameFramework.Localization;

namespace Game
{
    public static partial class AssetUtility
    {
        public static string GetLocalizationAsset(Language language)
        {
            return Utility.Text.Format("Assets/Res/Localization/{0}/Localization.bytes", language);
        }
    }
}