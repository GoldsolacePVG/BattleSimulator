using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

    // General variables
    public int game_turn = 2;
    public int gold_damage, minoto_damage, juliu_damage, ayuria_damage;
    public int rathalos_damage, glavenus_damage, nergigante_damage, zinogre_damage;
    public int gold_objective = 1, minoto_objective = 2, juliu_objective = 3, ayuria_objective = 0;

    // Character variables
    public Gold gold_;
    public Minoto minoto_;
    public Juliu juliu_;
    public Ayuria ayuria_;
    public Rathalos rathalos_;
    public Glavenus glavenus_;
    public Nergigante nergigante_;
    public Zinogre zinogre_;

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
            Debug.Log("Monsters Turn");
            // Rathalos Attack
        }else if(game_turn == 2 && Input.GetKeyDown(KeyCode.P)) {
            game_turn = 1;
            Debug.Log("Hunters Turn");
            // Gold attack
            if(hunterList_[0].is_alive){
                if(monsterList_[0].is_alive){
                    gold_damage = hunterList_[0].AttackGold((Gold)hunterList_[0], monsterList_[0]);
                    monsterList_[0].health -= gold_damage;
                    if(monsterList_[0].health <= 0){
                        monsterList_[0].is_alive = false;
                    }
                }
                if(monsterList_[gold_objective].is_alive && !monsterList_[0].is_alive){
                    gold_damage = hunterList_[0].AttackGold((Gold)hunterList_[0], monsterList_[gold_objective]);
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
                    minoto_damage = hunterList_[1].AttackMinoto((Minoto)hunterList_[1], monsterList_[1]);
                    monsterList_[1].health -= minoto_damage;
                    if(monsterList_[1].health <= 0){
                        monsterList_[1].is_alive = false;
                    }
                }
                if(monsterList_[minoto_objective].is_alive && !monsterList_[1].is_alive){
                    minoto_damage = hunterList_[1].AttackMinoto((Minoto)hunterList_[1], monsterList_[minoto_objective]);
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
                    juliu_damage = hunterList_[2].AttackJuliu((Juliu)hunterList_[2], monsterList_[2]);
                    monsterList_[2].health -= juliu_damage;
                    if(monsterList_[2].health <= 0){
                        monsterList_[2].is_alive = false;
                    }
                }
                if(monsterList_[juliu_objective].is_alive && !monsterList_[2].is_alive){
                    juliu_damage = hunterList_[2].AttackJuliu((Juliu)hunterList_[2], monsterList_[juliu_objective]);
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
                    ayuria_damage = hunterList_[3].AttackAyuria((Ayuria)hunterList_[3], monsterList_[3]);
                    monsterList_[3].health -= ayuria_damage;
                    if(monsterList_[3].health <= 0){
                        monsterList_[3].is_alive = false;
                    }
                }
                if(monsterList_[ayuria_objective].is_alive && !monsterList_[3].is_alive){
                    ayuria_damage = hunterList_[3].AttackAyuria((Ayuria)hunterList_[3], monsterList_[ayuria_objective]);
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
        }
    }
}