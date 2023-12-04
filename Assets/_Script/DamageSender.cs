using UnityEngine;

public class DamageSender : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damegeReceiver = collision.GetComponent<DamageReceiver>();
        if (damegeReceiver == null) return;
        damegeReceiver.Reciver(1);

        this.enemyCtrl.despawner.Despawn();
    }
}
