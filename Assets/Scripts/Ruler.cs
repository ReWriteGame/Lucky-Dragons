using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ruler : MonoBehaviour
{
    public static Ruler instance = null; // Ёкземпл€р объекта

    [SerializeField] private Enemy enemy;
    [SerializeField] private Hero hero;

    [SerializeField] private int heroDamage = 1;
    [SerializeField] private int enemyDamage = 1;

    [SerializeField] private DragonElementAnim dragonAnim;
    [SerializeField] private UnityEvent loseGameEvent;
    [SerializeField] private UnityEvent winGameEvent;
    [SerializeField] private UnityEvent winEvent;
    [SerializeField] private UnityEvent loseEvent;

    enum Elements { Stone = 0, Fire = 1, Water = 2 }

    void Start()
    {
        if (instance == null)
        { // Ёкземпл€р менеджера был найден
            instance = this; // «адаем ссылку на экземпл€р объекта
        }
        else if (instance == this)
        { // Ёкземпл€р объекта уже существует на сцене
            Destroy(gameObject); // ”дал€ем объект
        }
    }

    public void battle()
    {
        switch (findWinner(hero.CurrentElement, enemy.getRandomElement()))
        {
            case 1:
                print("Hero Win");
                winEvent?.Invoke();
                break;

            case 2:
                print("Hero Lose");
                loseEvent?.Invoke();
                break;

            case 0:
                print("Draw");
                break;
        }

        if (enemy.currentElement == (int)Elements.Stone) dragonAnim.stoneAnim();
        else if (enemy.currentElement == (int)Elements.Fire) dragonAnim.fireAnim();
        else if (enemy.currentElement == (int)Elements.Water) dragonAnim.waterAnim();

        if (!hero.life.haveHealth())
            loseGameEvent?.Invoke();

        if (!enemy.life.haveHealth())
            winGameEvent?.Invoke();
    }



    int findWinner(int moveHero, int moveEnemy)
    {
        if (moveHero == (int)Elements.Stone && moveEnemy == (int)Elements.Fire || moveHero == (int)Elements.Fire && moveEnemy == (int)Elements.Water || moveHero == (int)Elements.Water && moveEnemy == (int)Elements.Stone) return 1;
        if (moveHero == (int)Elements.Stone && moveEnemy == (int)Elements.Water || moveHero == (int)Elements.Fire && moveEnemy == (int)Elements.Stone || moveHero == (int)Elements.Water && moveEnemy == (int)Elements.Fire) return 2;
        return 0;// ничь€
    }

}
