using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCollection
{
    class Program
    {
      public static void Main()
        {
            Console.WriteLine((0 - (-1)));
            Console.ReadKey();
        }
        
    }

    public class Kata
    {
        public static string PigIt(string str)
        {
            string result = "";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                result += $"{word.Substring(1, word.Length - 1)}{word.Substring(0, 1)}ay ";
            }
            return result.Substring(0, result.Length - 1);
        }
        public static int find_it(int[] seq)
        {
            var count = seq
            .GroupBy(e => e)
            .Where(e => e.Count() % 2 != 0)
            .Select(e => e.First());
            int odd = 0;
            int oddCount = 0;
            foreach (int j in count)
            {
                odd = j;
            }
            
            return oddCount;
        }
        public static bool ValidatePin(string pin)
        {
            var regex = @"^\d{4}$|^\d{6}$";
            var match = Regex.Match(pin, regex);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int num1 = 0;
            int num2 = 0;
           for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == target)
                    {
                        num1 = i;
                        num2 =j;
                        break;
                    }
                }
            }
            int[] xxx = { num1, num2 };
            return xxx;
        }
        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(s => Regex.IsMatch(s, @"^([:;]{1}[~-]{0,1}[\)D]{1}$)"));
        }
        public static bool is_valid_IP(string IpAddres)
        {
            return Regex.IsMatch(IpAddres, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
}
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> ret = new List<string>();
            
            foreach (string a in words)
            {
                string aa = String.Concat(a.OrderBy(c => c));
                string bb = String.Concat(word.OrderBy(c => c));
                if (aa == bb)
                {
                    ret.Add(a);
                }
            }
            return ret;
        }
        public static string orderWeight(string strng)
        {
            List<int> weigths =new List<int>();
            string ret = "";
            string[] strngs = strng.Split(' ').ToArray();
            foreach(string s in strngs)
            {
                char[] temporaryCharArr = s.ToCharArray();
                int sum = 0;
                for(int i = 0; i < temporaryCharArr.Length; i++)
                {
                    sum += (int)Char.GetNumericValue(temporaryCharArr[i]);
                    if(i == temporaryCharArr.Length - 1)
                    {
                        weigths.Add(sum);
                    }
                }
                
            }
           
            foreach(int i in weigths)
            {
                ret += i + " ";
            }
            return ret.Substring(ret.Length - 1);
        }
        public static List<string> wave(string str)
        {
            return str
            .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
            .Where(x => x != str)
            .ToList();
        }
    }
    public class DirReduction
    {

        public static string[] dirReduc(string[] arr)
        {
            
            List<string> ret = new List<string>(arr);
            int index1 = 0;
            int index2 = 1;
            while (index2 < ret.Count())
            {
                if (IsOpposite(ret[index1], ret[index2]))
                {

                    ret.RemoveAt(index1);
                    ret.RemoveAt(index2 - 1);
                    index1 = 0;
                    index2 = 1;
                } else
                {
                    index1++;
                    index2++;
                }
            }
            
            return ret.ToArray();
        }

        public static bool IsOpposite (string a, string b)
        {
            bool ret = false;
            switch (a)
            {
                case "NORTH":
                    if (b == "SOUTH")
                    {
                        ret = true; ;
                    }
                    else
                    {
                        ret = false;
                    }
                    break;
                case "SOUTH":
                    if (b == "NORTH")
                    {
                        ret = true; ;
                    }
                    else
                    {
                        ret = false;
                    }
                    break;
                case "EAST":
                    if (b == "WEST")
                    {
                        ret = true; ;
                    }
                    else
                    {
                        ret = false;
                    }
                    break;
                case "WEST":
                    if (b == "EAST")
                    {
                        ret = true; ;
                    }
                    else
                    {
                        ret = false;
                    }
                    break;
            }
            return ret;
        }
    }

    public enum Result
    {
        Win,
        Loss,
        Tie
    }
    public class PokerHand
    {
        public PokerHand(string hand)
        {
        }

        public Result CompareWith(PokerHand hand)
        {
            return Result.Tie;
        }
    }
}
 