public class Rathalos : Monster {
  public Rathalos() {
    name = "Rathalos";
    id = 5;
    attack = 500;
    defence = 0;
    health = 1500;
    is_alive = true;
    race = "Flying Wyvern";
    element = (int)Elements.kFire;
    weakness = (int)Elements.kWater;
  }
}
