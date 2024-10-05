namespace TapeEquilibrium;

public static class Calculator
{
    public static int CalculateDiff(int[] input)
    {
        var result = int.MaxValue;
        
        var leftSum = 0;
        var rightSum = input.Sum();

        var p = 1;

        for (var i = 0; p < input.Length; i++, p++)
        {
            var current = input[i];

            leftSum += current;
            rightSum -= current;

            var diff = Math.Abs(leftSum - rightSum);
            
            Console.WriteLine($"P = {p}, difference = |{leftSum} - {rightSum}| = {diff}");

            if (result > diff)
            {
                result = diff;
            }
        }

        return result;
    }
}