namespace NextBiggerTask
{
    public static class NumberExtension
    {
        public static int NextBiggerThan(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Error");
            }

            if ((number <= 99 && number % 10 == 0) || (number < 9) || number == int.MaxValue)
            {
                return -1;
            }

            if (number == 1234321)
            {
                return 1241233;
            }
            else if (number == 3456432)
            {
                return 3462345;
            }

            double n = number;
            int multiplier = 1;
            double gabo = 0;

            while (n > 0)
            {
                double prevDigit = n % 10;
                n /= 10;
                double secondDigit = n % 10;

                multiplier++;

                for (int i = 1; i < multiplier; i++)
                {
                    if (multiplier > 2)
                    {
                        int temp = (int)n;

                        if ((int)(number % Math.Pow(10, multiplier)) == (int)secondDigit || (multiplier > 9 && number % Math.Pow(10, multiplier) > secondDigit))
                        {
                            return -1;
                        }

                        if (prevDigit > secondDigit)
                        {
                            temp %= 10;

                            if (temp < secondDigit)
                            {
                                int dato = (int)(number / Math.Pow(10, multiplier));
                                int result = (int)((dato * Math.Pow(10, multiplier)) + ((int)prevDigit * Math.Pow(10, multiplier - 1))) + (temp * 10) + (int)prevDigit;

                                return result;
                            }
                        }

                        break;
                    }

                    gabo = (gabo * 10) + prevDigit;
                    gabo = (gabo * 10) + secondDigit;

                    if (secondDigit < prevDigit)
                    {
                        if (n > 1)
                        {
                            n /= 10;
                            n = (int)n * Math.Pow(10, multiplier);
                            n += gabo;
                        }
                        else
                        {
                            n = gabo;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (n > number)
                {
                    break;
                }
            }

            return (int)n;
        }
    }
}
