static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return knightIsAwake ? false : true ;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return (knightIsAwake || archerIsAwake || prisonerIsAwake);
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (!archerIsAwake && prisonerIsAwake);
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && !archerIsAwake)
        {
            return true;
        }
        else if (prisonerIsAwake && !archerIsAwake && !knightIsAwake)
        {
            return true;
        }
        else return false;
    }
}
