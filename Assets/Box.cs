using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    public GameObject core;
    public GameObject result;
    public int row;
    public int col;
    //public GameObject result;
    void OnMouseDown()
    {
        row = GetComponent<Box>().row;
        col = GetComponent<Box>().col;
        int[,] boxes = core.GetComponent<GameController>().boxes;
        int flag = core.GetComponent<GameController>().flag;
        if(boxes[row,col]==0)
        {   if(flag%2==0)
            {
                boxes[row, col] = 1;
                GetComponent<SpriteRenderer>().sprite = core.GetComponent<GameController>().icons[0]; 
                
            }
            else if(flag%2!=0)
            {
                boxes[row, col] = 2;
                GetComponent<SpriteRenderer>().sprite = core.GetComponent<GameController>().icons[1];
                
            }
            flag = flag + 1;

        }
        else if(boxes[row,col]==1||boxes[row,col]==2)
            {}

        core.GetComponent<GameController>().flag = flag;

        if ((boxes[0, 0] == 1 && boxes[0, 1] == 1 && boxes[0, 2] == 1)
    || (boxes[1, 0] == 1 && boxes[1, 1] == 1 && boxes[1, 2] == 1)
        || (boxes[2, 0] == 1 && boxes[2, 1] == 1 && boxes[2, 2] == 1)
        || (boxes[0, 0] == 1 && boxes[1, 0] == 1 && boxes[2, 0] == 1)
        || (boxes[0, 1] == 1 && boxes[1, 1] == 1 && boxes[2, 1] == 1)
        || (boxes[0, 2] == 1 && boxes[1, 2] == 1 && boxes[2, 2] == 1)
        || (boxes[0, 0] == 1 && boxes[1, 1] == 1 && boxes[2, 2] == 1)
        || (boxes[0, 2] == 1 && boxes[1, 1] == 1 && boxes[2, 0] == 1)
    )
        {
            Debug.Log("O Win!");
            result.GetComponent<TextMesh>().text = ("O Win!");

        }
        else if ((boxes[0, 0] == 2 && boxes[0, 1] == 2 && boxes[0, 2] == 2)
        || (boxes[1, 0] == 2 && boxes[1, 1] == 2 && boxes[1, 2] == 2)
            || (boxes[2, 0] == 2 && boxes[2, 1] == 2 && boxes[2, 2] == 2)
            || (boxes[0, 0] == 2 && boxes[1, 0] == 2 && boxes[2, 0] == 2)
            || (boxes[0, 1] == 2 && boxes[1, 1] == 2 && boxes[2, 1] == 2)
            || (boxes[0, 2] == 2 && boxes[1, 2] == 2 && boxes[2, 2] == 2)
            || (boxes[0, 0] == 2 && boxes[1, 1] == 2 && boxes[2, 2] == 2)
            || (boxes[0, 2] == 2 && boxes[1, 1] == 2 && boxes[2, 0] == 2)
        )
        {
            Debug.Log("X Win!");
            result.GetComponent<TextMesh>().text = ("X Win!");

        }

    }

}
