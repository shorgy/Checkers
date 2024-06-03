using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject tileprefabWhite;
    [SerializeField] GameObject tileprefabGreen;
    [SerializeField] Board board;
    [SerializeField] GameObject pieceprefabRed;
    [SerializeField] GameObject pieceprefabBlue;

 //  static GameObject[,] BoardTiles = new GameObject[8, 8];
  static GameObject[,] PiecesMoves = new GameObject[8, 8];
  static public GameObject[,] Pieces = new GameObject[8, 8];

    void Start()
    {
        Debug.Log("Loggggg");
        CreateBoard();
    }

    void CreateBoard()
    {
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                if ((x + y) % 2 == 0)
                {
                    var TileGreen = Instantiate(tileprefabGreen, new Vector2(x, y), Quaternion.identity, board.transform);
                    TileGreen.name = $"Tile Green[ {x}, {y} ]"; Vector2 pos = TileGreen.transform.position;
                    if (y <= 2)
                    {
                        GameObject piece = Instantiate(pieceprefabRed, pos, Quaternion.identity, TileGreen.transform);
                        Piece redpiece = piece.GetComponent<Piece>();
                        
                        redpiece.GetComponent<Piece>();
                        redpiece.xIndex = x;
                        redpiece.yIndex = y;

                        Pieces[x, y] = piece;


                        Vector2 posRed = redpiece.transform.position;
                        redpiece.name = $"Red Piece({posRed.x},{posRed.y})";
                    }
                    if (y > 4)
                    {
                        
                        GameObject piece = Instantiate(pieceprefabBlue, pos, Quaternion.identity, TileGreen.transform);
                       
                        Piece bluepiece = piece.GetComponent<Piece>();

                        
                        bluepiece.xIndex = x;
                        bluepiece.yIndex = y;

                        Pieces[x, y] = piece;

                        Vector2 posBlue = bluepiece.transform.position;
                        bluepiece.name = $"Blue Piece({posBlue.x},{posBlue.y})";
                    }
                }
                else
                {
                    var TileWhite = Instantiate(tileprefabWhite, new Vector2(x, y), Quaternion.identity, board.transform);
                    TileWhite.name = $"Tile White[ {x}, {y} ]";
                }
            }
        }

    }

}
