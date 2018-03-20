using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {
    AudioSource run, attack, go_crazy, walk;
    public Animator anim;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
        run = GameObject.Find("run").GetComponent<AudioSource>();
        attack = GameObject.Find("attack").GetComponent<AudioSource>();
        go_crazy = GameObject.Find("gocrazy").GetComponent<AudioSource>();
        walk = GameObject.Find("walk").GetComponent<AudioSource>();
    }
        public void RobotActions(string Actions)
    {
        int result = string.CompareOrdinal(Actions, "run");
        if (result == 0)
        {
            anim.Play("Run_IP", -1, 0f);
            run.Play();
        }
        result = string.CompareOrdinal(Actions, "attack");
        if (result == 0)
        {
            anim.Play("Attack_Arm_1", -1, 0f);
            attack.Play();
        }
        result = string.CompareOrdinal(Actions, "go crazy");
        if (result == 0)
        {
            anim.Play("Idle_Crazy_Robot", -1, 0f);
            go_crazy.Play();
        }
        result = string.CompareOrdinal(Actions, "walk");
        if (result == 0)
        {
            anim.Play("Walk_IP", -1, 0f);
            walk.Play();
        }
    }
}
    

