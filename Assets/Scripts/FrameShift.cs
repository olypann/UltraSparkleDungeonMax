using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class FrameShift : MonoBehaviour
{
    
    private Animator main_Animator;
    public Animator char_Animator;

    public PanelShift main_panel;

    public float panel_id;

    public ParticleSystem stars;

    public CharacterScript character1;
    public CharacterScript character2;
    public CharacterScript character3;
    public CharacterScript character4;

    public CharacterList characters;

    void Start()
    {

        main_Animator = main_panel.GetComponent<Animator>();


        char_Animator = characters.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if(main_panel.panel_state == "default")
        {
            if (panel_id == 1)
            {
                main_Animator.SetTrigger("panel1_selected");

                character1.selected = true;

                character2.selected = false;
                character3.selected = false;
                character4.selected = false;

                char_Animator.SetTrigger("char1_selected");

            }
            else if (panel_id == 2)
            {
                main_Animator.SetTrigger("panel2_selected");

                character2.selected = true;

                character1.selected = false;
                character3.selected = false;
                character4.selected = false;

                char_Animator.SetTrigger("char2_selected");

            }
            else if (panel_id == 3)
            {
                main_Animator.SetTrigger("panel3_selected");

                character3.selected = true;

                character2.selected = false;
                character1.selected = false;
                character4.selected = false;

                char_Animator.SetTrigger("char3_selected");
            }
            else if (panel_id == 4)
            {
                main_Animator.SetTrigger("panel4_selected");

                character4.selected = true;

                character2.selected = false;
                character3.selected = false;
                character1.selected = false;

                char_Animator.SetTrigger("char4_selected");

            }
            main_panel.panel_state = "selected";

            
            stars.Play();
        }
        else
        {
            main_Animator.SetTrigger("default");
            main_panel.panel_state = "default";

            stars.Stop();

            character1.selected = false;
            character2.selected = false;
            character3.selected = false;
            character4.selected = false;

            char_Animator.SetTrigger("char_default");
        }
        

        Debug.Log("yipie!");
    }
}
