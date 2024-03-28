using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class PanelShift : MonoBehaviour
{
    private Animator main_Animator;



    public string panel_state = "default";

    void Start()
    {


        main_Animator = gameObject.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        /*if (panel_state == "default")
        {
            m_Animator.SetTrigger("def");
]
            state = "zoomed";
        }

        else if (panel_state == "panel1_selected")
        {
            m_Animator.SetTrigger("defaultSquare");

            Animator_2.SetTrigger("defaultSquare");
            Animator_3.SetTrigger("defaultSquare");
            Animator_4.SetTrigger("defaultSquare");

            state = "default";

            character2.state = "default";
            character3.state = "default";
            character4.state = "default";
        }

        else if (panel_state == "panel2_selected")
        {
            m_Animator.SetTrigger("defaultSquare");

            Animator_2.SetTrigger("defaultSquare");
            Animator_3.SetTrigger("defaultSquare");
            Animator_4.SetTrigger("defaultSquare");

            state = "default";

            character2.state = "default";
            character3.state = "default";
            character4.state = "default";
        }


        Debug.Log("yipie!");*/
    }
}
