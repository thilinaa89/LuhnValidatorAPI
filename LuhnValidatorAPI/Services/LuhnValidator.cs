namespace LuhnValidatorAPI.Services
{
    public class LuhnValidator : ILuhnValidator
    {
        public bool IsValid(string value)
        {
            int sum = 0;
            bool applyDouble = false;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                // validates if the character is a digit
                if (!char.IsDigit(value[i]))
                {
                    return false;
                }

                int num = int.Parse(value[i].ToString());

                //double every 2nd digit from the right
                if (applyDouble)
                {
                    num *= 2;

                    //substract 9 if the doubled value is greater than 9
                    if (num > 9)
                        num -= 9;
                }

                sum += num; // add result to sum
                applyDouble = !applyDouble; // toggle the flag
            }

            // card number is valid if sum modulus 10 is 0
            return (sum % 10 == 0);

        }
    }
}
