public class Zinogre : Monster {
  public Zinogre() {
    name = "Zinogre";
    id = 8;
    attack = 200;
    defence = 0;
    health = 2000;
    race = "Fanged Wyvern";
    element = (int)Elements.kThunder;
    weakness = (int)Elements.kIce;
  }
}
