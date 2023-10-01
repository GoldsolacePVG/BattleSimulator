public class Rathalos : Monster {
  public Rathalos() {
    name = "Rathalos";
    id = 5;
    attack = 100;
    defence = 0;
    health = 1500;
    race = "Flying Wyvern";
    element = (int)Elements.kFire;
    weakness = (int)Elements.kWater;
  }
}
