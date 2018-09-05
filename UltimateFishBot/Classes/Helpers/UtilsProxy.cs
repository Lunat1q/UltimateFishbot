using TiqUtils.TypeSpeccific;

namespace UltimateFishBot.Helpers
{
    public static class UtilsProxy
    {
        public static string RandomString(int length, string chars = "abcdefghijklmnopqrstuvwxyz0123456789")
        {
            return StringUtils.RandomString(length, chars);
        }
    }
}