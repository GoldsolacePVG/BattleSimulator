public class Minoto : Hunter {
  public Kamura_Bow kamura_bow;

  public Minoto() {
    name = "Minoto";
    id = 2;
    attack = 100;
    defence = 0;
    health = 100;
    is_alive = true;
    hunting_group = "Kamura Hunters";
    race = "Wyverian";
    hunter_type = "Hunter";
    kamura_bow = new Kamura_Bow();
  }
}