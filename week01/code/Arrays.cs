public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array with the requested length.
        double[] multiples = new double[length];

        // Step 2: Loop through each position in the array.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple by multiplying the supplied
            // number by the position number plus one.
            multiples[i] = number * (i + 1);
        }

        // Step 4: Return the completed array containing the multiples.
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Find the position where the list should be split.
        // For a right rotation, the last 'amount' items move to the front.
        int splitIndex = data.Count - amount;

        // Step 2: Create a copy of the items that will move to the front.
        List<int> rightPart = data.GetRange(splitIndex, amount);

        // Step 3: Create a copy of the items that will remain at the back.
        List<int> leftPart = data.GetRange(0, splitIndex);

        // Step 4: Remove all existing items from the original list.
        data.Clear();

        // Step 5: Add the right part first because those items need to
        // appear at the beginning after the rotation.
        data.AddRange(rightPart);

        // Step 6: Add the left part after the right part.
        data.AddRange(leftPart);
    }
}
