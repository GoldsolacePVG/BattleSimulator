using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

    // General variables
    public int game_turn = 2;
    public int gold_damage, minoto_damage, juliu_damage, ayuria_damage;
    public int rathalos_damage, glavenus_damage, nergigante_damage, zinogre_damage;

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
        hunterList_ = new List<Hunter>();
        monsterList_ = new List<Monster>();

        // Hunters
        hunterList_.Add(gold_); // Gold = 0
        hunterList_.Add(minoto_); // Minoto = 1
        hunterList_.Add(juliu_); // Juliu = 2
        hunterList_.Add(ayuria_); // Ayuria = 3

        // Monsters
        monsterList_.Add(rathalos_); // Rathalos = 4
        monsterList_.Add(glavenus_); // Glavenus = 5
        monsterList_.Add(nergigante_); // Nergigante = 6
        monsterList_.Add(zinogre_); // Zinogre = 7

        Debug.Log("WELCOME TO MONSTER HUNTER BATTLE SIMULATOR");
        Debug.Log("PRESS P");
    }

    // Update is called once per frame
    void Update() {
        if(game_turn == 1 && Input.GetKeyDown(KeyCode.P)) {
            game_turn = 2;
            Debug.Log("Monsters Turn");
        }else if(game_turn == 2 && Input.GetKeyDown(KeyCode.P)) {
            game_turn = 1;
            Debug.Log("Hunters Turn");
            Debug.Log(hunterList_[0].name);
            // Debug.Log(monsterList_[0].health);
            // monsterList_[0].health -= gold_damage;
            // Debug.Log(monsterList_[0].health);
        }
    }
}