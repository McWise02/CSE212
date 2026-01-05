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
        // TODO Problem 1 Start
        // First initialize a list of doubles of the correct length.
        // next, use a loop to fill in each position in the list with the correct multiple.
        //return the list converted to an array.

        List<double> results = new();

        for (int i = 0; i < length; i++)
        {
            results.Add(number * (i+1));
        }

        return results.ToArray(); // replace this return statement with your own
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
        // TODO Problem 2 Start
        //copy the list to a new array
        //loop through the array at i and do i % data.length. if it is 0, add data.length to i and use that as the index in the new array.
        //if it isn't 0, add the remainder to i and assign that to the index
        //return the final list aas an array

        var new_array = data.ToArray();
        var length = data.ToArray().Length;
        for (int i = 0; i < length; i++)
        {
            if ((i + amount) < length)
            {
                data[i+amount] = new_array[i];
            }
            if ((i + amount) >= length)
            {
                data[(i + amount) % length] = new_array[i];
            }
        }
        
    }
}
