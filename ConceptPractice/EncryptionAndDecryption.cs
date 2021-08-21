using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConceptPractice
{
    public static class EncryptionAndDecryption
    {

    //}

    //public static class Encryption
    //{
        private static readonly Dictionary<string, string> subst = new Dictionary<string, string> { { "=", "$" }, { "+", "-" }, { "/", "*" } };


        public static string DecodeForUrlBase64(this string src)
        {
            try
            {
                var srcbase64 = DecodeForUrl(src);

                var stringDecoded = Convert.FromBase64String(srcbase64);

                return Encoding.UTF8.GetString(stringDecoded);
            }
            catch
            {
                return null;
            }
        }

        public static string EncodeForUrlBase64(this string src)
        {
            try
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(src ?? "");
                return EncodeForUrl(Convert.ToBase64String(plainTextBytes));
            }
            catch
            {
                return null;
            }
        }


        public static string EncodeForUrl(this string src)
        {
            var res = src ?? "";

            res = subst.Aggregate(res, (current, pair) => current.Replace(pair.Key, pair.Value));

            if (res.EndsWith("$$"))
                res = "$" + res.Substring(0, res.Length - 1);

            return HttpUtility.UrlEncode(res);
        }

        public static string DecodeForUrl(this string src)
        {
            var res = HttpUtility.UrlDecode(src ?? "");

            if (res.StartsWith("$"))
                res = res.Substring(1) + "$";

            res = subst.Aggregate(res, (current, pair) => current.Replace(pair.Value, pair.Key));

            return res;
        }
    }
}
