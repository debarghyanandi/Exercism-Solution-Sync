static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch (speed)
        {
            case 0:
                return 0;
            case int n when n>= 1 && n<=4:
                return 1;
            case int n when n>= 5 && n<=8:
                return 0.9;
            case 9:
                return 0.8;
            case 10:
                return 0.77;
            default:
            return 0.0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        var result = speed * 221 * SuccessRate(speed);
        return result;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double res = (ProductionRatePerHour(speed) / 60);
        int result = (int)((ProductionRatePerHour(speed) / 60));
        return result;
    }
}
