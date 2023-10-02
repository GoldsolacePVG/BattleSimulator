using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

    // General variables
    public int game_turn = 2;
    public int gold_damage, minoto_damage, juliu_damage, ayuria_damage;
    public int rathalos_damage, glavenus_damage, nergigante_damage, zinogre_damage;
    public int gold_objective = 1, minoto_objective = 2, juliu_objective = 3, ayuria_objective = 0;
    public int rathalos_objective = 1, glavenus_objective = 2, nergigante_objective = 3, zinogre_objective = 0;

    // Character variables
    public Character gold_;
    public Character minoto_;
    public Character juliu_;
    public Character ayuria_;
    public Character rathalos_;
    public Character glavenus_;
    public Character nergigante_;
    public Character zinogre_;

    // Character list
    public List<Hunter> hunterList_;
    public List<Monster> monsterList_;

    // Start is called before the first frame update
    void Start() {
        gold_ = new Gold();
        minoto_ = new Minoto();
        juliu_ = new Juliu();
        ayuria_ = new Ayuria();
        rathalos_ = new Rathalos();
        glavenus_ = new Glavenus();
        nergigante_ = new Nergigante();
        zinogre_ = new Zinogre();

        hunterList_ = new List<Hunter>();
        monsterList_ = new List<Monster>();

        // Hunters
        hunterList_.Add(gold_); // Gold = 0
        hunterList_.Add(minoto_); // Minoto = 1
        hunterList_.Add(juliu_); // Juliu = 2
        hunterList_.Add(ayuria_); // Ayuria = 3

        // Monsters
        monsterList_.Add(rathalos_); // Rathalos = 0
        monsterList_.Add(glavenus_); // Glavenus = 1
        monsterList_.Add(nergigante_); // Nergigante = 2
        monsterList_.Add(zinogre_); // Zinogre = 3

        Debug.Log("WELCOME TO MONSTER HUNTER BATTLE SIMULATOR");
        Debug.Log("PRESS P");
    }

    // Update is called once per frame
    void Update() {
        if(game_turn == 1 && Input.GetKeyDown(KeyCode.P)) {
            game_turn = 2;
            Debug.Log("Monsters Turn\n\n");
            // Rathalos Attack
            if(monsterList_[0].is_alive){
                if(hunterList_[0].is_alive){
                    rathalos_damage = monsterList_[0].Attack(monsterList_[0], hunterList_[0]);
                    hunterList_[0].health = hunterList_[0].TakeDamage(monsterList_[0],); // NO TERMINADO
                    if(hunterList_[0].health <= 0){
                        hunterList_[0].is_alive = false;
                    }
                }
                if(hunterList_[rathalos_objective].is_alive && !hunterList_[0].is_alive){
                    rathalos_damage = monsterList_[0].Attack(monsterList_[0], hunterList_[rathalos_objective]);
                    hunterList_[rathalos_objective].health -= rathalos_damage;
                    if(hunterList_[rathalos_objective].health <= 0){
                        hunterList_[rathalos_objective].is_alive = false;
                        if(rathalos_objective < 3){
                            rathalos_objective += 1;
                        }
                    }
                }else if(!hunterList_[rathalos_objective].is_alive){
                    if(rathalos_objective < 3){
                        rathalos_objective += 1;
                    }
                    Debug.Log("MONSTERS: Rathalos changing opponent");
                }
            }
            // Glavenus Attack
            if(monsterList_[1].is_alive){
                if(hunterList_[1].is_alive){
                    glavenus_damage = monsterList_[1].Attack(monsterList_[1], hunterList_[1]);
                    hunterList_[1].health -= glavenus_damage;
                    if(hunterList_[1].health <= 0){
                        hunterList_[1].is_alive = false;
                    }
                }
                if(hunterList_[glavenus_objective].is_alive && !hunterList_[1].is_alive){
                    glavenus_damage = monsterList_[1].Attack(monsterList_[1], hunterList_[glavenus_objective]);
                    hunterList_[glavenus_objective].health -= glavenus_damage;
                    if(hunterList_[glavenus_objective].health <= 0){
                        hunterList_[glavenus_objective].is_alive = false;
                        if(glavenus_objective < 3){
                            glavenus_objective += 1;
                            if(glavenus_objective == 4){
                                glavenus_objective = 0;
                            }
                        }
                    }
                }else if(!hunterList_[glavenus_objective].is_alive){
                    if(glavenus_objective < 3){
                        glavenus_objective += 1;
                    }
                    Debug.Log("MONSTERS: Glavenus changing opponent");
                }
            }
            // Nergigante Attack
            if(monsterList_[2].is_alive){
                if(hunterList_[2].is_alive){
                    nergigante_damage = monsterList_[2].Attack(monsterList_[2], hunterList_[2]);
                    hunterList_[2].health -= nergigante_damage;
                    if(hunterList_[2].health <= 0){
                        hunterList_[2].is_alive = false;
                    }
                }
                if(hunterList_[nergigante_objective].is_alive && !hunterList_[2].is_alive){
                    nergigante_damage = monsterList_[2].Attack(monsterList_[2], hunterList_[nergigante_objective]);
                    hunterList_[nergigante_objective].health -= nergigante_damage;
                    if(hunterList_[nergigante_objective].health <= 0){
                        hunterList_[nergigante_objective].is_alive = false;
                        if(nergigante_objective < 3){
                            nergigante_objective += 1;
                            if(nergigante_objective == 4){
                                nergigante_objective = 0;
                            }
                        }
                    }
                }else if(!hunterList_[nergigante_objective].is_alive){
                    if(nergigante_objective < 3){
                        nergigante_objective += 1;
                    }
                    Debug.Log("MONSTERS: Nergigante changing opponent");
                }
            }
            // Zinogre Attack
            if(monsterList_[3].is_alive){
                if(hunterList_[3].is_alive){
                    zinogre_damage = monsterList_[3].Attack(monsterList_[3], hunterList_[3]);
                    hunterList_[3].health -= zinogre_damage;
                    if(hunterList_[3].health <= 0){
                        hunterList_[3].is_alive = false;
                    }
                }
                if(hunterList_[zinogre_objective].is_alive && !hunterList_[3].is_alive){
                    zinogre_damage = monsterList_[3].Attack(monsterList_[3], hunterList_[zinogre_objective]);
                    hunterList_[zinogre_objective].health -= zinogre_damage;
                    if(hunterList_[zinogre_objective].health <= 0){
                        hunterList_[zinogre_objective].is_alive = false;
                        if(zinogre_objective < 3){
                            zinogre_objective += 1;
                            if(zinogre_objective == 4){
                                zinogre_objective = 0;
                            }
                        }
                    }
                }else if(!hunterList_[zinogre_objective].is_alive){
                    if(zinogre_objective < 3){
                        zinogre_objective += 1;
                    }
                    Debug.Log("MONSTERS: Zinogre changing opponent");
                }
            }

            if(!hunterList_[0].is_alive && !hunterList_[1].is_alive && !hunterList_[2].is_alive && !hunterList_[3].is_alive){
                game_turn = 3;
            }
        }else if(game_turn == 2 && Input.GetKeyDown(KeyCode.P)) {
            game_turn = 1;
            Debug.Log("Hunters Turn\n\n");
            // Gold attack
            if(hunterList_[0].is_alive){
                if(monsterList_[0].is_alive){
                    gold_damage = hunterList_[0].Attack(hunterList_[0], monsterList_[0]);
                    monsterList_[0].health -= gold_damage;
                    if(monsterList_[0].health <= 0){
                        monsterList_[0].is_alive = false;
                    }
                }
                if(monsterList_[gold_objective].is_alive && !monsterList_[0].is_alive){
                    gold_damage = hunterList_[0].Attack(hunterList_[0], monsterList_[gold_objective]);
                    monsterList_[gold_objective].health -= gold_damage;
                    if(monsterList_[gold_objective].health <= 0){
                        monsterList_[gold_objective].is_alive = false;
                        if(gold_objective < 3){
                            gold_objective += 1;
                        }
                    }
                }else if(!monsterList_[gold_objective].is_alive){
                    if(gold_objective < 3){
                        gold_objective += 1;
                    }
                    Debug.Log("HUNTERS: Gold changing opponent");
                }
            }
            // Minoto attack
            if(hunterList_[1].is_alive){
                if(monsterList_[1].is_alive){
                    minoto_damage = hunterList_[1].Attack(hunterList_[1], monsterList_[1]);
                    monsterList_[1].health -= minoto_damage;
                    if(monsterList_[1].health <= 0){
                        monsterList_[1].is_alive = false;
                    }
                }
                if(monsterList_[minoto_objective].is_alive && !monsterList_[1].is_alive){
                    minoto_damage = hunterList_[1].Attack(hunterList_[1], monsterList_[minoto_objective]);
                    monsterList_[minoto_objective].health -= minoto_damage;
                    if(monsterList_[minoto_objective].health <= 0){
                        monsterList_[minoto_objective].is_alive = false;
                        if(minoto_objective < 3){
                            minoto_objective += 1;
                            if(minoto_objective == 4){
                                minoto_objective = 0;
                            }
                        }
                    }
                }else if(!monsterList_[minoto_objective].is_alive){
                    if(minoto_objective < 3){
                        minoto_objective += 1;
                    }
                    Debug.Log("HUNTERS: Minoto changing opponent");
                }
            }
            // Juliu attack
            if(hunterList_[2].is_alive){
                if(monsterList_[2].is_alive){
                    juliu_damage = hunterList_[2].Attack(hunterList_[2], monsterList_[2]);
                    monsterList_[2].health -= juliu_damage;
                    if(monsterList_[2].health <= 0){
                        monsterList_[2].is_alive = false;
                    }
                }
                if(monsterList_[juliu_objective].is_alive && !monsterList_[2].is_alive){
                    juliu_damage = hunterList_[2].Attack(hunterList_[2], monsterList_[juliu_objective]);
                    monsterList_[juliu_objective].health -= juliu_damage;
                    if(monsterList_[juliu_objective].health <= 0){
                        monsterList_[juliu_objective].is_alive = false;
                        if(juliu_objective < 3){
                            juliu_objective += 1;
                            if(juliu_objective == 4){
                                juliu_objective = 0;
                            }
                        }
                    }
                }else if(!monsterList_[juliu_objective].is_alive){
                    if(juliu_objective < 3){
                        juliu_objective += 1;
                    }
                    Debug.Log("HUNTERS: Juliu changing opponent");
                }
            }
            // Ayuria attack
            if(hunterList_[3].is_alive){
                if(monsterList_[3].is_alive){
                    ayuria_damage = hunterList_[3].Attack(hunterList_[3], monsterList_[3]);
                    monsterList_[3].health -= ayuria_damage;
                    if(monsterList_[3].health <= 0){
                        monsterList_[3].is_alive = false;
                    }
                }
                if(monsterList_[ayuria_objective].is_alive && !monsterList_[3].is_alive){
                    ayuria_damage = hunterList_[3].Attack(hunterList_[3], monsterList_[ayuria_objective]);
                    monsterList_[ayuria_objective].health -= ayuria_damage;
                    if(monsterList_[ayuria_objective].health <= 0){
                        monsterList_[ayuria_objective].is_alive = false;
                        if(ayuria_objective < 3){
                            ayuria_objective += 1;
                            if(ayuria_objective == 4){
                                ayuria_objective = 0;
                            }
                        }
                    }
                }else if(!monsterList_[ayuria_objective].is_alive){
                    if(ayuria_objective < 3){
                        ayuria_objective += 1;
                    }
                    Debug.Log("HUNTERS: Ayuria changing opponent");
                }
            }

            if(!monsterList_[0].is_alive && !monsterList_[1].is_alive && !monsterList_[2].is_alive && !monsterList_[3].is_alive){
                game_turn = 3;
            }
        }else if(!hunterList_[0].is_alive && !hunterList_[1].is_alive && !hunterList_[2].is_alive && !hunterList_[3].is_alive && Input.GetKeyDown(KeyCode.P)){
            Debug.Log("MONSTERS WIN!");
        }else if(!monsterList_[0].is_alive && !monsterList_[1].is_alive && !monsterList_[2].is_alive && !monsterList_[3].is_alive && Input.GetKeyDown(KeyCode.P)){
            Debug.Log("HUNTERS WIN");
        }
    }
}