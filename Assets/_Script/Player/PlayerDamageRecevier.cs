public class PlayerDamageRecevier : DamageReceiver
{
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    public override void Reciver(int damage)
    {
        base.Reciver(damage);
        if (this.IsDead())
        {
            this.playerCtrl.playerStatus.Dead();
            UIManager.Instance.btnReplay.SetActive(true);
        }
    }
}
