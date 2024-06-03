using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public interface ISelected : IPointerEnterHandler, IPointerExitHandler
{
    public void ChangeColorOnPointer(PointerEventData eventData, SpriteRenderer spriteRenderer, Color originalColor)
    {
        originalColor = spriteRenderer.color;
        OnPointerEnter(eventData);
        spriteRenderer.color = Color.yellow;
        OnPointerExit(eventData);
        spriteRenderer.color = originalColor;

    }
}
