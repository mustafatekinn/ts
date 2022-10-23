using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator Pickaxesanimator,Blocksanimator;
    void Start()
    {
        Pickaxesanimator = gameObject.GetComponent<Animator>(); 
        Blocksanimator =  GameObject.Find("Blocks").GetComponent<Animator>();

    }

    public void Clickedscreen()
    {
        StartCoroutine(Clickedanimation()); // line 17
    }
    IEnumerator Clickedanimation()
    {
        Pickaxesanimator.SetBool("Click", true); // Pickaxes click animation start
        Blocksanimator.SetBool("Click", true); // Pickaxes click animation start
        yield return new WaitForSeconds(0.3f); // Pickaxes click animation cooldown
        Pickaxesanimator.SetBool("Click", false); // Pickaxes click animation stop
        Blocksanimator.SetBool("Click", false); // Pickaxes click animation stop
    }
}
