using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;

    public bool selected = false;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            Debug.Log("reveal");
            spriteRenderer.maskInteraction = SpriteMaskInteraction.None; 
        }
        if (!selected)
        {
            Debug.Log("hide");
            spriteRenderer.maskInteraction = SpriteMaskInteraction.VisibleOutsideMask;
        }
    }
}
