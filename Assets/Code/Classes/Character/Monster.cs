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
}
