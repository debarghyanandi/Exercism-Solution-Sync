class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
public int ExpectedMinutesInOven() 
{
    int result = 40;
    return result;
}
    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven(int time) 
{
    int result = (40 - time);
    return result;
}
    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int layers) 
{
    int result = (2*layers);
    return result;
}
    // TODO: define the 'ElapsedTimeInMinutes()' method
 public int ElapsedTimeInMinutes(int eTime, int alreadyCook ) 
{
    var result = PreparationTimeInMinutes(eTime);
    int finalResult = result + alreadyCook;
    return finalResult;
}
}
