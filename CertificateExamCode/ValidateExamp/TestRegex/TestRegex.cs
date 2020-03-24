using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.TestRegex
{
    using System.Text.RegularExpressions;

    class TestRegex
    {
        public static void DoSample()
        {
            string input = "http://www.aaaa.com http://www.aaaa.com http://www.aaaa.com http://www.aaaa.com aaaa a a a a";
            string pattern = @"http://(www\.)?([^\.]+)\.com";

            List<string> result =  new List<string>();
            List<string> result1 =  new List<string>();
            List<string> result3 =  new List<string>();
            List<string> result4 =  new List<string>();

            var regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            var abc = matches.GetEnumerator();
            while (abc.MoveNext())
            {
                result1.Add(abc.Current.ToString());
            }

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            result3 = (from Match m in matches select m.Value).ToList<string>();

            result4  =  (List<string>)matches.GetEnumerator();
        }
    }
}
