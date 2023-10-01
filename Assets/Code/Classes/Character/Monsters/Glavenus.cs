public class Glavenus : Monster {
  public Glavenus() {
    name = "Glavenus";
    id = 6;
    attack = 350;
    defence = 0;
    health = 3000;
    is_alive = true;
    race = "Brute Wyvern";
    element = (int)Elements.kFire;
    weakness = (int)Elements.kWater;
  }
}
