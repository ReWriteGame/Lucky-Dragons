using UnityEngine;

[RequireComponent(typeof(LifeBar))]
public class Enemy : MonoBehaviour
{
    [HideInInspector] public LifeBar life;


    private int lastElement = 0;
    public int currentElement = 0;
    private void Start()
    {
        life = GetComponent<LifeBar>();
    }

    public int getRandomElement()
    {
        lastElement = currentElement;
        currentElement = Random.Range(0, 3);
        print($"Enemy {currentElement}");
        return currentElement;
    }
}
