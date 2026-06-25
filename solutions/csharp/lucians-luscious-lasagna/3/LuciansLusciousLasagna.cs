class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven(int time) 
{
    return (40 - time);
}
    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int layers) 
{
    return (2*layers);
}
    // TODO: define the 'ElapsedTimeInMinutes()' method
 public int ElapsedTimeInMinutes(int eTime, int alreadyCook ) 
{
    var result = PreparationTimeInMinutes(eTime);
    return (result + alreadyCook);
}
}
