public class Solution {
    public string IntToRoman(int num)
        {
            var result = "";

            var symbolOrder = new List<string> { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            var symbolValues = new List<int> { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            
            while(num > 0) {
                var value = GetMaxValueToSubsctract(num);

                num -= value;

                result += symbolOrder[symbolValues.IndexOf(value)];
            }

            return result;
        }

        public int GetMaxValueToSubsctract(int num)
        {
            var symbolValues = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};

            foreach(var value in symbolValues )
                if (num >= value) return value;

            return 0;
        }
}