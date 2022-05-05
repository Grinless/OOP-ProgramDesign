using System.Collections;
using UnityEngine;

public class Item_SpeedUpgrade : Item
{
    protected override void Effect(Player p)
    {
        p.Speed += 0.5f;
        base.DisableItem();
    }
}

public class Item_HealthCapUpgrade : Item
{
    protected override void Effect(Player p)
    {
        p.MaxHealth++;
        base.DisableItem(); 
    }
}

public class Item_HealthPickup : Item
{
    private int _healthValue = 1; 

    protected override void Effect(Player p)
    {
        p.CurrentHealth += _healthValue;
        base.DisableItem(); 
    }
}

public class Item_HealthFillPickup : Item
{
    protected override void Effect(Player p)
    {
        p.CurrentHealth = p.MaxHealth;
        base.DisableItem(); 
    }
}

public class Item_ScreenClearPickup : Item
{
    protected override void Effect(Player p)
    {
        //TODO:: IMPLEMENT THIS FUNCTIONALITY. 
    }
}