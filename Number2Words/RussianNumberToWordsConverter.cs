using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2Words
{
    public enum GrammaticalGender
    {
        /// <summary>
        /// Indicates masculine grammatical gender
        /// </summary>
        Masculine,
        /// <summary>
        /// Indicates feminine grammatical gender
        /// </summary>
        Feminine,
        /// <summary>
        /// Indicates neuter grammatical gender
        /// </summary>
        Neuter
    }

    internal enum RussianGrammaticalNumber
    {
        Singular,
        Paucal,
        Plural
    }

    internal static class RussianGrammaticalNumberDetector
    {
        public static RussianGrammaticalNumber Detect(int number)
        {
            var tens = number % 100 / 10;
            if (tens != 1)
            {
                var unity = number % 10;

                if (unity == 1) // 1, 21, 31, 41 ... 91, 101, 121 ...
                    return RussianGrammaticalNumber.Singular;

                if (unity > 1 && unity < 5) // 2, 3, 4, 22, 23, 24 ...
                    return RussianGrammaticalNumber.Paucal;
            }

            return RussianGrammaticalNumber.Plural;
        }
    }

    public class RussianNumberToWordsConverter
    {
        private static readonly string[] HundredsMap = { "ноль", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
        private static readonly string[] TensMap = { "ноль", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        private static readonly string[] UnitsMap = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
        private static readonly string[] UnitsOrdinalPrefixes = { string.Empty, string.Empty, "двух", "трёх", "четырёх", "пяти", "шести", "семи", "восьми", "девяти", "десяти", "одиннадцати", "двенадцати", "тринадцати", "четырнадцати", "пятнадцати", "шестнадцати", "семнадцати", "восемнадцати", "девятнадцати" };
        private static readonly string[] TensOrdinalPrefixes = { string.Empty, "десяти", "двадцати", "тридцати", "сорока", "пятидесяти", "шестидесяти", "семидесяти", "восьмидесяти", "девяносто" };
        private static readonly string[] TensOrdinal = { string.Empty, "десят", "двадцат", "тридцат", "сороков", "пятидесят", "шестидесят", "семидесят", "восьмидесят", "девяност" };
        private static readonly string[] UnitsOrdinal = { string.Empty, "перв", "втор", "трет", "четверт", "пят", "шест", "седьм", "восьм", "девят", "десят", "одиннадцат", "двенадцат", "тринадцат", "четырнадцат", "пятнадцат", "шестнадцат", "семнадцат", "восемнадцат", "девятнадцат" };

        public static string Convert(int number, GrammaticalGender gender)
        {
            if (number == 0)
                return "ноль";

            var parts = new List<string>();

            if (number < 0)
            {
                parts.Add("минус");
                number = -number;
            }

            CollectParts(parts, ref number, 1000000000, GrammaticalGender.Masculine, "миллиард", "миллиарда", "миллиардов");
            CollectParts(parts, ref number, 1000000, GrammaticalGender.Masculine, "миллион", "миллиона", "миллионов");
            CollectParts(parts, ref number, 1000, GrammaticalGender.Feminine, "тысяча", "тысячи", "тысяч");

            if (number > 0)
                CollectPartsUnderOneThousand(parts, number, gender);

            return string.Join(" ", parts);
        }

        private static void CollectPartsUnderOneThousand(ICollection<string> parts, int number, GrammaticalGender gender)
        {
            if (number >= 100)
            {
                var hundreds = number / 100;
                number %= 100;
                parts.Add(HundredsMap[hundreds]);
            }

            if (number >= 20)
            {
                var tens = number / 10;
                parts.Add(TensMap[tens]);
                number %= 10;
            }

            if (number > 0)
            {
                if (number == 1 && gender == GrammaticalGender.Feminine)
                    parts.Add("одна");
                else if (number == 1 && gender == GrammaticalGender.Neuter)
                    parts.Add("одно");
                else if (number == 2 && gender == GrammaticalGender.Feminine)
                    parts.Add("две");
                else if (number < 20)
                    parts.Add(UnitsMap[number]);
            }
        }

        private static void CollectParts(ICollection<string> parts, ref int number, int divisor, GrammaticalGender gender, params string[] forms)
        {
            if (number < divisor) return;
            var result = number / divisor;
            number %= divisor;

            CollectPartsUnderOneThousand(parts, result, gender);
            parts.Add(ChooseOneForGrammaticalNumber(result, forms));
        }

        private static int GetIndex(RussianGrammaticalNumber number)
        {
            if (number == RussianGrammaticalNumber.Singular)
                return 0;

            if (number == RussianGrammaticalNumber.Paucal)
                return 1;

            return 2;
        }

        private static string ChooseOneForGrammaticalNumber(int number, string[] forms)
        {
            return forms[GetIndex(RussianGrammaticalNumberDetector.Detect(number))];
        }

    }
}
