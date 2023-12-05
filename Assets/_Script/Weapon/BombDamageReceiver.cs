public class BombDamageReceiver : DamageReceiver
{
    //[Header("DamageReceiver")]

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            Destroy(gameObject);
            EffectManager.instance.SpawnVFX("Explosion_B", transform.position, transform.rotation);
        };
    }
}
