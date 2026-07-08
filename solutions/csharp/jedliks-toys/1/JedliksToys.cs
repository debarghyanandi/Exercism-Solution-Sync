class RemoteControlCar
{
    public int distance = 0;
    public int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
      return battery>0 ? $"Battery at {battery}%" : $"Battery empty";
    }

    public void Drive()
    {    
        if (battery > 0)
            {
                distance = distance + 20;
                battery = battery - 1;
            }
    }
}
