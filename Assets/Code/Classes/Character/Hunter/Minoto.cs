public class Minoto : Hunter {
  public Minoto() {
    name = "Minoto";
    id = 2;
    attack = 100;
    defence = 100;
    health = 100;
    is_alive = true;
    hunting_group = "Kamura Hunters";
    race = "Wyverian";
    hunter_type = "Hunter";
    weapon = new Kamura_Bow();
  }
}