using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExFizzBuzzTDD
{
    public class FizzBuzzer
    {

        const string FIRST_MULTIPLE_WORD = "Fizz";
        const string SECOND_MULTIPLE_WORD = "Buzz";
        const int FIRST_MULTIPLE_VALUE = 3;
        const int SECOND_MULTIPLE_VALUE = 5;
        public static readonly ReadOnlyCollection<NumericStringStorage> DEFAULT_RULES = new ReadOnlyCollection<NumericStringStorage>
            (new List<NumericStringStorage>{
                new NumericStringStorage(FIRST_MULTIPLE_VALUE, FIRST_MULTIPLE_WORD),
                new NumericStringStorage(SECOND_MULTIPLE_VALUE, SECOND_MULTIPLE_WORD) });



        private List<NumericStringStorage> _rules;

        public List<NumericStringStorage> Rules
        {
            get { return _rules; }
            set { _rules = value; }
        }

        public FizzBuzzer(List<NumericStringStorage> pRules)
        {
            this._rules = pRules;
        }
        public FizzBuzzer() :
            {

        }
        public string Apply2(int number)
        {

            if (number % (FIRST_MULTIPLE_VALUE * SECOND_MULTIPLE_VALUE) == 0)
            {
                return FIRST_MULTIPLE_WORD + SECOND_MULTIPLE_WORD;
            }

            if (number % FIRST_MULTIPLE_VALUE == 0)
            {
                return FIRST_MULTIPLE_WORD;
            }

            if (number % SECOND_MULTIPLE_VALUE == 0)
            {
                return SECOND_MULTIPLE_WORD;
            }
            return number.ToString();
        }
        public string Apply3(int number)
        {

            string result = "";

            if (number % FIRST_MULTIPLE_VALUE == 0)
            {
                result += FIRST_MULTIPLE_WORD;
            }

            if (number % SECOND_MULTIPLE_VALUE == 0)
            {
                result += SECOND_MULTIPLE_WORD;
            }

            return result == "" ? number.ToString() : result;
        }

        public string Apply(int number)
        {
            string FIRST_MULTIPLE_WORD = "Fizz";
            string SECOND_MULTIPLE_WORD = "Buzz";
            int FIRST_MULTIPLE_VALUE = 3;
            int SECOND_MULTIPLE_VALUE = 5;

            NumericStringStorage[] rules = new NumericStringStorage[2] {
        new NumericStringStorage(FIRST_MULTIPLE_VALUE, FIRST_MULTIPLE_WORD),
        new NumericStringStorage(SECOND_MULTIPLE_VALUE, SECOND_MULTIPLE_WORD)
      };

            string result = "";
            foreach (NumericStringStorage rule in rules)
            {
                if (number % rule.Number == 0)
                {
                    result += rule.Word;
                }
            }

            return result == "" ? number.ToString() : result;
        }
    }
}
