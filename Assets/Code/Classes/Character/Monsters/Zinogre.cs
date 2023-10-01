public class Zinogre : Monster {
  public Zinogre() {
    name = "Zinogre";
    id = 8;
    attack = 400;
    defence = 0;
    health = 2000;
    is_alive = true;
    race = "Fanged Wyvern";
    element = (int)Elements.kThunder;
    weakness = (int)Elements.kIce;
  }
}
