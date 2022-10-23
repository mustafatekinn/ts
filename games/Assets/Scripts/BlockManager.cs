using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
     [Header("BLOCKS")]
    public GameObject[] Blocks;
    public static int Blockint;
    

    public void BlockRandomize()
    {
        Blockint = Random.RandomRange(0,GameManager.Pickaxesint+1); // random block code
        foreach(GameObject block in Blocks)
        {
            block.active = false; // all block SetActive 
        }
        Blocks[Blockint].SetActive(true); // Selected block SetActive(true)
    }
}
