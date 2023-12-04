using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 27f;
    public float disLimit = 6f;
    public float randPos = 0;

    private void Start()
    {
        this.player = PlayerCtrl.instance.transform;

        this.randPos = Random.Range(-6, 6);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 pos = this.player.position;

        pos.x = randPos;

        Vector3 distance = pos - transform.position;
        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
