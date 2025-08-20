
Dictionary<int, int> FrequencyCounter(int[] roll)
{
    // Function to count the frequency of each number in the roll array.
    // Time complexity: O(n), where n = roll.Length.
    //
    // Parameters:
    // roll (int[]): Array of integers.
    //
    // Returns:
    // Dictionary<int, int>: Dictionary with numbers as keys and their frequencies as values.
    //
    // Edge cases:
    // - If roll is null or empty, returns an empty dictionary.
    var count = new Dictionary<int, int>();
    if (roll == null || roll.Length == 0) return count;

    foreach (var num in roll)
    {
        if (count.ContainsKey(num))
            count[num]++;
        else
            count[num] = 1;
    }
    return count;
}

int CalculateMaxScore(int[] roll)
{
    // Calculate the maximum score for a dice roll.
    // Score = max(X * frequency of X) for X from 1 to J.
    //
    // Parameters:
    // roll (int[]): Array of integers from 1 to J (roll results).
    //
    // Returns:
    // int: The maximum score.
    //
    // Edge cases:
    // - If roll is null or empty (I=0), returns 0.
    // - If all numbers are the same, calculates correctly (e.g., all 1 -> 1 * I).
    if (roll == null || roll.Length == 0)
        return 0;

    var count = FrequencyCounter(roll);
    int maxScore = 0;
    foreach (var pair in count)
    {
        int score = pair.Key * pair.Value;
        if (score > maxScore)
            maxScore = score;
    }
    return maxScore;
}

try
{
    // Input I and J from user
    Console.Write("Enter the number of dice (I): ");
    int I = int.Parse(Console.ReadLine());
    Console.Write("Enter the number of sides per die (J): ");
    int J = int.Parse(Console.ReadLine());

    if (I < 0 || J < 1)
        throw new ArgumentException("I must be >= 0 and J must be >= 1.");

    // Start time measurement
    var startTime = DateTime.Now;

    // Run 1000 rounds
    Random rand = new();
    for (int roundNum = 1; roundNum <= 1000; roundNum++)
    {
        // Generate random roll: I numbers from 1 to J
        int[] roll = Enumerable.Range(1, I).Select(_ => rand.Next(1, J + 1)).ToArray();

        // Calculate score
        int score = CalculateMaxScore(roll);

        // Display score and roll for each round
        Console.WriteLine($"Round {roundNum}: [{string.Join(", ", roll)}] => Score = {score}");
    }

    // End time measurement
    var endTime = DateTime.Now;
    var totalTime = (endTime - startTime).TotalSeconds;

    // Display total time
    Console.WriteLine($"Total time: {totalTime:F4} seconds");
}
catch (FormatException)
{
    Console.WriteLine("Error: Please enter valid integers.");
}
catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Unexpected error: {e.Message}");
}
