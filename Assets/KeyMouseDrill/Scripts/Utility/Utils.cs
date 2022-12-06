using System.Text;

namespace KeyMouDrill
{
    public class Utils
    {
        // システム依存の文字列の文字コードをUTF8に変換
        public static string ConvertToUTF8(string origString)
        {
            byte[] bytesUtf8 = Encoding.Default.GetBytes(origString);
            return ConvertToUTF8FromBytes(bytesUtf8);
        }

        public static string ConvertToUTF8FromBytes(byte[] bytesUtf8)
        {
            return Encoding.UTF8.GetString(bytesUtf8);
        }
    }
}
