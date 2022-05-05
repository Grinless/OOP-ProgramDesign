using Game.Systems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemIdentifiers
{
    NONE,
    HEALTH_PICKUP,
    HEALTH_FILL,
    HEALTH_CAP_UPGRADE,
    SPEED_UPGRADE,
    SCREEN_CLEAR_PICKUP
}

/// <summary>
/// Class responsible for building item instances. 
/// </summary>
public class ItemBuilder
{
    public static GameObject BuildItem(ItemIdentifiers type)
    {
        GameObject obj = new GameObject();
        obj.AddComponent<BoxCollider2D>();
        obj.AddComponent<SpriteRenderer>(); 

        switch (type)
        {
            case ItemIdentifiers.NONE:
                obj = null;
                break;
            case ItemIdentifiers.HEALTH_PICKUP:
                obj.AddComponent<Item_HealthPickup>(); 
                break;
            case ItemIdentifiers.HEALTH_FILL:
                obj.AddComponent<Item_HealthFillPickup>(); 
                break;
            case ItemIdentifiers.HEALTH_CAP_UPGRADE:
                obj.AddComponent<Item_HealthCapUpgrade>();
                break;
            case ItemIdentifiers.SPEED_UPGRADE:
                obj.AddComponent<Item_SpeedUpgrade>();
                break;
            case ItemIdentifiers.SCREEN_CLEAR_PICKUP:
                obj.AddComponent<Item_ScreenClearPickup>();
                break;
            default:
                obj = null; 
                break;
        }

        return obj; 
    }
}

/// <summary>
/// Contains derivable item functionality.
/// </summary>
public abstract class Item : EngineFunctionProvider
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    protected virtual void DisableItem()
    {
        this.gameObject.SetActive(false); 
    }

    protected abstract void Effect(Player p);


    protected override void OnCollisionEnter2DCall(GameObject obj)
    { 
        if (obj != GameManager.Entity_Player.gameObject)
            return;
        Effect((Player)GameManager.Entity_Player);
    }
}


