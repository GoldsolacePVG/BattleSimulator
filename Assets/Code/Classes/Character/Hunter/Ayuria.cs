public class Ayuria : Hunter {
  public Barioth_Horn barioth_horn;

  public Ayuria() {
    name = "Ayuria";
    id = 4;
    attack = 100;
    defence = 200;
    health = 1000;
    is_alive = true;
    hunting_group = "Hero Riders";
    race = "Human";
    hunter_type = "Rider";
    barioth_horn = new Barioth_Horn();
  }
}