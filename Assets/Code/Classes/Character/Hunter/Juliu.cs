public class Juliu : Hunter {
  public Rath_Katana rath_katana;

  public Juliu() {
    name = "Juliu";
    id = 3;
    attack = 100;
    defence = 300;
    health = 2000;
    is_alive = true;
    hunting_group = "Inferno Hunters";
    race = "Human";
    hunter_type = "Hunter";
    rath_katana = new Rath_Katana();
  }
}