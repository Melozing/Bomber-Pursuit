using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    protected int hp = 3;

    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }

    public virtual void Reciver(int damage)
    {
        this.hp -= damage;
    }

}
