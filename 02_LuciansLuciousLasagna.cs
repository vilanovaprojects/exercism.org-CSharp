class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method


        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        // TODO: define the 'RemainingMinutesInOven()' method

        public int RemainingMinutesInOven(int remaining)
        {
            return 40 - remaining;
        }

        // TODO: define the 'PreparationTimeInMinutes()' method

        public int PreparationTimeInMinutes(int layer1)
        {
            return layer1 * 2;
        }

        // TODO: define the 'ElapsedTimeInMinutes()' method

        public int ElapsedTimeInMinutes(int layer1, int remaining)
        {
            return remaining + PreparationTimeInMinutes(layer1);
        }
}