using UnityEngine;

public class Hunter : Character {
    public string hunting_group;
    public string race;
    public string hunter_type;

    public Hunter(){}
    
    public virtual void AttackGold() {Debug.Log("Hello");}
    public virtual void AttackMinoto() {}
    public virtual void AttackJuliu() {}
    public virtual void AttackAyuria() {}
}
