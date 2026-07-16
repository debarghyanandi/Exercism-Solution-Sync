abstract class Character
{
    private string character;
    protected Character(string characterType)
    {
        character = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {character}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6 ;
    }
}

class Wizard : Character
{
    private bool spell = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
      return spell ? 12 : 3;
    }

    public void PrepareSpell()
    {
        spell = true;
    }
    public override bool Vulnerable()
    {
        return !(spell);
    }

}
