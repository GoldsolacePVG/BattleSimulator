[System.Serializable]
public class Character {
    public string name;
    public int id;
    public int attack;
    public int defence;
    public int health;
    public bool is_alive;

    public Character(){}

    public virtual int Attack(){
        int damage = attack;

        return damage;
    }

    public virtual int TakeDamage(Character monster,int damage_dealt){
        int health = health - damage_dealt;

        return health;
    }
}
