using System.Collections.Generic;

public class QueueAlgorithms
{
    public char FirstNonRepeatingCharacter(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        Queue<char> queue = new Queue<char>();

        foreach (char c in input)
        {
            if (!frequency.ContainsKey(c))
                frequency[c] = 0;

            frequency[c]++;
            queue.Enqueue(c);

            while (queue.Count > 0 && frequency[queue.Peek()] > 1)
            {
                queue.Dequeue();
            }
        }

        return queue.Count > 0 ? queue.Peek() : '#';
    }
}