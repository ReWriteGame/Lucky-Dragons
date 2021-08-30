using UnityEngine;

public class LifeBar : MonoBehaviour
{
    [Range(0, 100), SerializeField] private int health = 0;// current num of lifes

    public int Health { get => health; private set => health = value; }

    public void getHealth(int size)
    {
        if (size < 0) return;
        health += size;
    }
    public void getDamage(int size)
    {
        if (size < 0) return;
        health -= size;
    }

    public bool haveHealth()
    {
        return health <= 0 ? false : true;
    }
}
// может максималочку дописать