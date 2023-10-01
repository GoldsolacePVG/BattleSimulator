public class Nergigante : Monster {
  public Nergigante() {
    name = "Nergigante";
    id = 7;
    attack = 800;
    defence = 0;
    health = 6000;
    is_alive = true;
    race = "Elder Dragon";
    element = (int)Elements.kRaw;
    weakness = (int)Elements.kThunder;
  }
}
