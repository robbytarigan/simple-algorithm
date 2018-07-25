/**
 * As prisoners, I want to be the last one that to be escaped from King game execution. The executioner always says some repeated words from the left to right before shooting the one it finished the word with.
 * For example if the word is "MINI MANY MO" and there are four prisoners, then the third one is getting executed first. This continues until the last one that end up being released. 
 */

using System.Collections.Generic;
using System.Diagnostics;

namespace SimpleAlgorithm
{    
    public class KingGame
    {
        public short ReleasedNumber(short prisonersCount, short wordsCount)
        {
            LinkedList<short> prisoners = new LinkedList<short>();

            for (short p = 1; p < prisonersCount + 1; p++)
            {
                prisoners.AddLast(p);
            }

            var aimedPrisoner = prisoners.First;
            
            for (short p = 0; p < prisonersCount - 1; p++)
            {
                for (short w = 0; w < wordsCount - 1; w++)
                {
                    aimedPrisoner = aimedPrisoner.Next ?? prisoners.First;
                }

                var nextAimedPrisoner = aimedPrisoner.Next ?? prisoners.First;
                prisoners.Remove(aimedPrisoner);
                aimedPrisoner = nextAimedPrisoner;
            }

            Debug.Assert(prisoners.Count == 1);
            return prisoners.First.Value;
        }
    }
}
