class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven(int time) => (40 - time);

    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int layers) => (2*layers);

    // TODO: define the 'ElapsedTimeInMinutes()' method
 public int ElapsedTimeInMinutes(int eTime, int alreadyCook ) =>  (PreparationTimeInMinutes(eTime)+alreadyCook);

}
