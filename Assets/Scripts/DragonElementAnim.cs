using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonElementAnim : MonoBehaviour
{
    [SerializeField] private Animation stone;
    [SerializeField] private Animation fire;
    [SerializeField] private Animation water;



    public void stoneAnim()
    {
        showAnim(stone);
    }
    public void fireAnim()
    {
        showAnim(fire);
    }
    public void waterAnim()
    {
        showAnim(water);
    }
    public void showAnim(Animation animation)
    {
        animation.Play();
    }
}
