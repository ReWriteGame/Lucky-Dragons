using UnityEngine;

[RequireComponent(typeof(LifeBar))]
public class Hero : MonoBehaviour
{
    [HideInInspector] public LifeBar life;



    private int lastElement = 0;
    public int currentElement = 0;
    public int CurrentElement { get => currentElement; private set => currentElement = value; }
    public int LastElement { get => lastElement; private set => lastElement = value; }

    private void Start()
    {
        life = GetComponent<LifeBar>();
    }

    public void setElement(int index = 0)
    {
        if (0 > index || index > 2)
        {
            Debug.Log("IndexOutOfRangeException");
            return;
        }
        lastElement = currentElement;
        currentElement = index;
        print($"Hero {index}");
    }
   
}
