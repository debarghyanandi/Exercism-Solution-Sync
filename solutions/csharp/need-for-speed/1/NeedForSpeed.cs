class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    public int distanceDriven;
    public int battery;
    
    public RemoteControlCar (int speed, int batteryDrain)
    {
       this.speed = speed;
       this.batteryDrain = batteryDrain;
        this.distanceDriven = 0;
        this.battery = 100;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return this.distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }

    public bool CanFinishTrack(int distance)
    {
        return (battery / batteryDrain) * speed >= distance;
    }
}

class RaceTrack
{
    public int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return car.CanFinishTrack(distance);
    }
}
