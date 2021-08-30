using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarVisual : MonoBehaviour
{
    [SerializeField] private LifeBar LifeBar;


    [SerializeField] private List<GameObject> healthPoint;
   

    public void checkHealth()
    {
            for (int i = LifeBar.Health; i < healthPoint.Count; i++)
                healthPoint[i].SetActive(false);
        
    }
}
