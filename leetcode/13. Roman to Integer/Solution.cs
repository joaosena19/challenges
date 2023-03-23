public class Solution {
    public int RomanToInt(string s) {
        var result = 0;

            var symbolOrder = new List<char> { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            var symbolValues = new List<int> { 1, 5, 10, 50, 100, 500, 1000 };

            var reverseString = s.Reverse().ToList();

            var previousValue = 0;

            foreach (var letter in reverseString)
            {
                var symbolPosition = symbolOrder.IndexOf(letter);
                var symbolValue = symbolValues[symbolPosition];

                if(previousValue > symbolValue)
                    result -= symbolValue;
                else result += symbolValue;

                previousValue = symbolValue;
            }

            return result;
    }
}