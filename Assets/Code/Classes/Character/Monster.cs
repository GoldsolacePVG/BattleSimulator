using UnityEngine;

public class Monster : Character{
    public string race;
    public int element;
    public int weakness;

    public enum Elements {
        kFire, kIce, KDraco, kThunder, kWater, kRaw, kEnergy
    };

    public Monster(){}

    public override int TakeDamage(Character hunter, int damage_dealt){
        if(weakness == hunter.weapon.elemental_attack){
            damage_dealt += 200;
        }else if(hunter.weapon.elemental_attack == 5){
            damage_dealt += 100;
        }
        int health_aux = health - damage_dealt;

        Debug.Log("HUNTERS: " + hunter.name + " has dealt " + damage_dealt + " damage to " + name);
        return health_aux;
    }
}
