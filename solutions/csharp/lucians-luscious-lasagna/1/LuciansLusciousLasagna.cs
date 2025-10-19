class Lasagna
{
    private int expectedMinutesInOven = 40;
    private int timeToPrepareLayerMinutes = 2;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return this.expectedMinutesInOven;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int elaspsedTimeInMinutes)
    {
        int remainingMinutesInOven = this.expectedMinutesInOven - elaspsedTimeInMinutes;
        return remainingMinutesInOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return this.timeToPrepareLayerMinutes*numberOfLayers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
    {
        int lapsedTimeInMinutes = numberOfLayers*this.timeToPrepareLayerMinutes + minutesInOven;
        return lapsedTimeInMinutes;
    }

    
}
