[System.Serializable]
public class Character {
    // En caso de querer mostrar una variable aunque sea "private" usar:
    // [SerializeField]
    // Para poder verla en Unity
    // Estructura:
    // [SerializeField]
    // private type name;
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

    public virtual int TakeDamage(Hunter hunter, int damage_dealt){
        int health_var = health - damage_dealt;

        return health;
    }

    public virtual int TakeDamage(Monster monster,int damage_dealt){
        int health_var = health - damage_dealt;

        return health;
    }
}
