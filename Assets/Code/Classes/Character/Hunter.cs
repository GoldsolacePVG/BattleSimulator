using UnityEngine;

[System.Serializable]
public class Hunter : Character {
    public string hunting_group;
    public string race;
    public string hunter_type;
    public Weapon weapon;

    public Hunter(){}
    
    public virtual int Attack(Hunter hunter, Monster monster) {
        int damage = hunter.attack * hunter.weapon.attack_multiplier;

        return damage;
    }

    public virtual int TakeDamage(Hunter hunter, Monster monster, int damage_dealt){
        int health = hunter.health -= damage_dealt;

        return health;
    }
}
