using UnityEngine;

[System.Serializable]
public class Hunter : Character {
    public string hunting_group;
    public string race;
    public string hunter_type;

    public Hunter(){}
    
    public virtual int AttackGold(Gold gold, Monster monster) {
        int gold_damage = gold.attack * gold.kamura_katana.attack_multiplier;

        if(monster.weakness == gold.kamura_katana.elemental_attack){
            gold_damage += 200;
        }else if(gold.kamura_katana.elemental_attack == 5){
            gold_damage += 100;
        }

        Debug.Log("HUNTERS: " + gold.name + " has dealt " + gold_damage + " damage to " + monster.name);

        return gold_damage;
    }

    public virtual int AttackMinoto(Minoto minoto, Monster monster) {
        int minoto_damage = minoto.attack * minoto.kamura_bow.attack_multiplier;

        if(monster.weakness == minoto.kamura_bow.elemental_attack){
            minoto_damage += 200;
        }else if(minoto.kamura_bow.elemental_attack == 5){
            minoto_damage += 100;
        }

        Debug.Log("HUNTERS: " + minoto.name + " has dealt " + minoto_damage + " damage to " + monster.name);

        return minoto_damage;
    }

    public virtual int AttackJuliu(Juliu juliu, Monster monster) {
        int juliu_damage = juliu.attack * juliu.rath_katana.attack_multiplier;

        if(monster.weakness == juliu.rath_katana.elemental_attack){
            juliu_damage += 200;
        }else if(juliu.rath_katana.elemental_attack == 5){
            juliu_damage += 100;
        }

        Debug.Log("HUNTERS: " + juliu.name + " has dealt " + juliu_damage + " damage to " + monster.name);

        return juliu_damage;
    }

    public virtual int AttackAyuria(Ayuria ayuria, Monster monster) {
        int ayuria_damage = ayuria.attack * ayuria.barioth_horn.attack_multiplier;

        if(monster.weakness == ayuria.barioth_horn.elemental_attack){
            ayuria_damage += 200;
        }else if(ayuria.barioth_horn.elemental_attack == 5){
            ayuria_damage += 100;
        }

        Debug.Log("HUNTERS: " + ayuria.name + " has dealt " + ayuria_damage + " damage to " + monster.name);

        return ayuria_damage;
    }
}
