public class Nergigante : Monster {
  public Nergigante() {
    name = "Nergigante";
    id = 7;
    attack = 500;
    defence = 0;
    health = 5000;
    race = "Elder Dragon";
    element = (int)Elements.kRaw;
    weakness = (int)Elements.kThunder;
  }
}
