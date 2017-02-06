class StepInPrimes 
{
    public static long[] Step(int g, long m, long n) 
    {
        
        while(true)
        {
            if (IsPrime(m))
            {
                if (IsPrime(m + g))
                {
                    // the first pair
                    return new long[] {m, m + g};
                }
            }

            if (m++ == n)
            {
                // no result
                null;
            }
        }

    }

    /// <summary>
    /// Check if a number is prime
    /// </summary>
    /// <param name="candidate"></param>
    /// <returns></returns>
    public static bool IsPrime(long candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Note:
        // ... This version was changed to test the square.
        // ... Original version tested against the square root.
        // ... Also we exclude 1 at the end.
        for (long i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}

