using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
    public class PolicyChecker
    {
        public int Min { get; set; }

        public int Max { get; set; }

        public char ReqChar { get; set; }

        public string Password { get; set; }

        // First try/solution
        //public PolicyChecker(string input)
        //{
        //    var split = input.Split(':');
        //    Password = split.ElementAtOrDefault(1);

        //    split = split.ElementAtOrDefault(0)?.Split(' ');
        //    ReqChar = split.ElementAtOrDefault(1)[0];

        //    split = split.ElementAtOrDefault(0)?.Split('-');
        //    Min = Convert.ToInt32(split.ElementAtOrDefault(0));
        //    Max = Convert.ToInt32(split.ElementAtOrDefault(1));
        //}

        public PolicyChecker(string input)
        {
            string[] separators = new string[] { "-", " ", ":" };
            var split = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Password = split.LastOrDefault();
            Min = Convert.ToInt32(split.ElementAtOrDefault(0));
            Max = Convert.ToInt32(split.ElementAtOrDefault(1));
            ReqChar = split.ElementAtOrDefault(2)[0];
        }

        public bool Check()
        {
            var reqCharCount = Password.Count(c => c == ReqChar);
            return Min <= reqCharCount && Max >= reqCharCount;
        }
    }
}
