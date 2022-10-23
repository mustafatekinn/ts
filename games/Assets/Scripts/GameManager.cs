using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [Header("UIELEMENTS")]
    public float coin;
    public Image levelupline;
    [Header("PICKAXES")]
    public GameObject[] Pickaxes;
    public static int Pickaxesint; 
    
    void Update()
    {
         
        if (Input.GetMouseButtonDown(0))
        {
            coin += (BlockManager.Blockint + 1) * Random.RandomRange(0.01f,0.05f); // add coin for level up
            levelupline.fillAmount = coin;
            gameObject.GetComponent<BlockManager>().BlockRandomize(); // Block randomize
            GameObject.Find("Pickaxes Controller").GetComponent<AnimationController>().Clickedscreen(); // Pickaxes click animation
        }
        if ((coin >= 1) && (Pickaxesint < 7)) // Level up
        {
            coin = 0; 
            Pickaxeslevelup();
        }
    }
    void Pickaxeslevelup()
    {
        Pickaxesint++; // level up
        foreach(GameObject Pickaxes in Pickaxes)
        {
        Pickaxes.active = false; // all pickaxes SetActive(false)
        }
        Pickaxes[Pickaxesint].SetActive(true); // Selected pickaxes SetActive(true)
    }
}
