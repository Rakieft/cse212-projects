public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // Create an array to store the multiples
        double[] result = new double[length];

        // Go through each position in the array
        for (int i = 0; i < length; i++)
        {
            // Multiply the number by the position + 1
            result[i] = number * (i + 1);
        }

        // Return the completed array
        return result;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // Find where to split the list
        int start = data.Count - amount;

        // Save the values that move to the front
        List<int> endPart = data.GetRange(start, amount);

        // Save the beginning part of the list
        List<int> firstPart = data.GetRange(0, start);

        // Empty the original list
        data.Clear();

        // Add the rotated values first
        data.AddRange(endPart);

        // Add the remaining values
        data.AddRange(firstPart);
    }
}