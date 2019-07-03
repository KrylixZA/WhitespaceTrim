namespace WhitespaceTrim
{
    public static class Trimmer
    {
        public static string Trim(string input)
        {
            var output = input[0].ToString();

            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] != ' ' && input[i] != '\t')
                {
                    output += input[i];
                }
            }

            return output;
        }
    }
}
