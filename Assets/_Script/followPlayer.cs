using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 27f;
    public float disLimit = 6f;

    private void Start()
    {
        this.player = PlayerCtrl.instance.transform;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
