using UnityEngine;

public class Monster : Character{
    public string race;
    public int element;
    public int weakness;

    public enum Elements {
        kFire, kIce, KDraco, kThunder, kWater, kRaw, kEnergy
    };

    public Monster(){}

    public virtual int Attack(Monster monster, Hunter hunter){
        int damage = monster.attack;
        damage -= hunter.defence;

        Debug.Log("MONSTERS: " + monster.name + " has dealt " + damage + " damage to " + hunter.name);
        return damage;
    }

    public virtual int TakeDamage(Monster monster, Hunter hunter, int damage_dealt){
        if(monster.weakness == hunter.weapon.elemental_attack){
            damage_dealt += 200;
        }else if(hunter.weapon.elemental_attack == 5){
            damage_dealt += 100;
        }
        int health = monster.health - damage_dealt;

        Debug.Log("HUNTERS: " + hunter.name + " has dealt " + damage_dealt + " damage to " + monster.name);
        return health;
    }
}
