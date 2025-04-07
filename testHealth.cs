using System.Collections;
using UnityEngine;

public class testHealth : MonoBehaviour
{
    public BoxCollider2D PlayerCollider;
    public Rigidbody2D PlayerRigid;
    private float jumpPower = 5f;
     private int live = 3;
     private IEnumerator DisableColliderAfterDelay(float delay)
     {
        yield return new WaitForSeconds(delay);
        PlayerCollider.enabled = false;
     }
     
void KillPlayer()
{
    PlayerRigid.linearVelocity = Vector2.zero;
    PlayerRigid.AddForce(Vector2.up*jumpPower, ForceMode2D.Impulse);
    StartCoroutine(DisableColliderAfterDelay(0.1f));
}
    void Hit()
    {
        live -= 1;
        if(live == 0)
        {
            KillPlayer();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Hit();
        }
    }







}