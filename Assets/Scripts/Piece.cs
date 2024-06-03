using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine;

public class Piece : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    public static Piece Selected;

    public int xIndex;
    public int yIndex;
    
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
        
    }


    private void Update()
    {

    }

   public void OnPointerEnter(PointerEventData eventData)
    {
        if (this != Selected )
            spriteRenderer.color = Color.black;
    
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        if (this != Selected)
            spriteRenderer.color = originalColor;
    }

    private void OnMouseDown()
    {
        if(Selected != null)
        {
            Selected.spriteRenderer.color = originalColor;
        }
        Selected = null;
        Selected = this;
        Selected.spriteRenderer.color = Color.yellow;
        if (Selected != null) Debug.Log($" Selected is {Selected.xIndex}, {Selected.yIndex}");
    }

}








