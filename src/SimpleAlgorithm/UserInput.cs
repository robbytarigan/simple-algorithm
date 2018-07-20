/**
 * User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.
 * Implement the class TextInput that contains:
 * Public method void Add(char c) - adds the given character to the current value
 * Public method string GetValue() - returns the current value
 * Implement the class NumericInput that:
 * Inherits TextInput
 * Overrides the Add method so that each non-numeric character is ignored
 * For example, the following code should output "10":
 * TextInput input = new NumericInput();
 * input.Add('1');
 * input.Add('a');
 * input.Add('0');
 * Console.WriteLine(input.GetValue());
 */

using System.Linq;
using System.Text;

namespace SimpleAlgorithm
{

    public class TextInput
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public virtual void Add(char value)
        {
            _stringBuilder.Append(value);
        }

        public string GetValue()
        {
            return _stringBuilder.ToString();
        }
    }

    public class NumericInput : TextInput
    {
        private static readonly char[] AcceptedCharacters = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};        

        public override void Add(char value)
        {
            if (AcceptedCharacters.Contains(value))
            {
                base.Add(value);
            }
        }        
    }

    //public class UserInput
    //{
    //    public static void Main(string[] args)
    //    {
    //        //TextInput input = new NumericInput();
    //        //input.Add('1');
    //        //input.Add('a');
    //        //input.Add('0');
    //        //Console.WriteLine(input.GetValue());
    //    }
    //}
}
