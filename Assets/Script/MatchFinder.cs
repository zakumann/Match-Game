using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchFinder : MonoBehaviour
{
    private Board board;

    private void Awake()
    {
        board = FindObjectOfType<Board>();
    }

    public void FindAllMatches()
    {
        for (int x = 0; x < board.width; x++)
        {
            for (int y = 0; y < board.height; y++)
            {

                Gem currenGem = board.allGems[x, y];
                if(currenGem != null)
                {
                    if(x > 0 && x < board.width - 1)
                    {
                        Gem leftGem = board.allGems[x - 1, y];
                        Gem RightGem = board.allGems[x + 1, y];
                        if(leftGem != null && RightGem != null)
                        {

                        }
                    }
                }
            }
        }
    }
}
