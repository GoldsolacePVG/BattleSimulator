public class Gold : Hunter {
  public Gold() {
    name = "Gold";
    id = 1;
    attack = 100;
    defence = 100;
    health = 100;
    is_alive = true;
    hunting_group = "Inferno Hunters";
    race = "Human";
    hunter_type = "Both";
    weapon = new Kamura_Katana();
    armor = new Master_Kamura_Armor();
  }
}
