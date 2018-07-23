/**
 * A palindrome is a word that reads the same backward or forward.
 * Write a function that checks if a given word is a palindrome. Character case should be ignored.
 * For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
 */

namespace SimpleAlgorithm
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }

            string lowerCaseWord = word.ToLowerInvariant();
            var length = lowerCaseWord.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (lowerCaseWord[i] != lowerCaseWord[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
        
    }
}
