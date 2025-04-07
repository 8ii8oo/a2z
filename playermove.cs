using UnityEngine;
using UnityEngine.InputSystem;

public class playermove : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject BulletPrefab;
    public float BulletSpeed;
    public Vector2 dirVec;


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-speed *Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed *Time.deltaTime, 0, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            dirVec = (mousePosition - (Vector2)transform.position).normalized;
            
            GameObject Bullet = Instantiate(BulletPrefab);
            Bullet.transform.position = transform.position;

            Rigidbody2D bulletRb = Bullet.GetComponent<Rigidbody2D>();

            bulletRb.linearVelocity = dirVec * BulletSpeed;


        }
    }
}
