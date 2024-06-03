using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    RaycastHit2D hit;
    Ray ray;


    private void Start()
    {

       
    }
    private void Update()
    {
        ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(ray, Vector2.zero);

        if (Piece.Selected != null && Input.GetMouseButtonDown(0))
        {
            Piece.Selected.transform.position = new Vector3(hit.point.x, hit.point.y, Piece.Selected.transform.position.z);
        }

    private bool IsMoveValid(GameObject[,] Pieces, int x, int y)
    {
        if(x <= 0 || x >= Pieces.GetLength(0) || y <= 0 || y >= Pieces.GetLength(1)) return false;
        if (Pieces[x, y] != null) return false;

        return true;
       
    }
    private void MovePiece()
    {
       var selected = Piece.Selected;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (hit.collider != null && Piece.Selected != null && Input.GetMouseButtonDown(0))
        {

            Piece.Selected.transform.position = hit.point;
            Debug.Log("Залупа");

        }
    }
        

  

}
