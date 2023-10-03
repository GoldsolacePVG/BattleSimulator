using UnityEngine;

[System.Serializable]
public class Hunter : Character {
    public string hunting_group;
    public string race;
    public string hunter_type;
    public Weapon weapon;
    public Armor armor;

    public Hunter(){}
    
    public override int Attack() {
        int damage = attack * weapon.attack_multiplier;

        return damage;
    }

    public override int TakeDamage(Character monster, int damage_dealt){
        health = health * armor.health_multiplier;
        defence = defence * armor.defence_multiplier;
        damage_dealt -= defence;
        int health_aux = health -= damage_dealt;

        Debug.Log("MONSTERS: " + monster.name + " has dealt " + damage + " damage to " + name);
        return health_aux;
    }
}
