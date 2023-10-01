public class Gold : Hunter {
  public Kamura_Katana kamura_katana;
  
  public Gold() {
    name = "Gold";
    id = 1;
    attack = 100;
    defence = 400;
    health = 3000;
    is_alive = true;
    hunting_group = "Inferno Hunters";
    race = "Human";
    hunter_type = "Both";
    kamura_katana = new Kamura_Katana();
  }
}
