//Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.
//For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.
//Asked by Facebook

// A naive recursive C# implementation
// to count number of decodings that
// can be formed from a given digit sequence
char[] digits = { '1', '2', '3', '4' };
DecodeNumber(digits);

void DecodeNumber(char[] digits) {
	int n = digits.Length;
	Console.Write("Count is ");
	Console.Write(countWays(digits, n));		
}

static int countDecoding(char[] digits, int n)
	{
		// base cases
		if (n == 0 || n == 1)
			return 1;

		// Initialize count
		int count = 0;

		// If the last digit is not 0, then
		// last digit must add to
		// the number of words
		if (digits[n - 1] > '0')
			count = countDecoding(digits, n - 1);

		// If the last two digits form a number
		// smaller than or equal to 26, then
		// consider last two digits and recur
		if (digits[n - 2] == '1'
			|| (digits[n - 2] == '2'
				&& digits[n - 1] < '7'))
			count += countDecoding(digits, n - 2);

		return count;
	}

// Given a digit sequence of length n,
	// returns count of possible decodings by
	// replacing 1 with A, 2 with B, ... 26 with Z
	static int countWays(char[] digits, int n)
	{
		if (n == 0 || (n == 1 && digits[0] == '0'))
			return 0;
		return countDecoding(digits, n);
	}
