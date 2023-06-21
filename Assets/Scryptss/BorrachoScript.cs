using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrachoScript : MonoBehaviour
{
    public int life = 100;
    
    public float speed = 1f;

    public bool vivo = true;

    public SpriteRenderer sprite;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(vivo)
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if(life <= 0)
        {
            vivo = false;
            animator.Play("Morir");
        }
    }

    private void OnMouseDown()
    {
        life -= 10;
        StartCoroutine(herido());
    }

    IEnumerator herido()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "TagArbol")
            animator.Play("Vomito");
    }

    public void AtacarArbol()
    {
        ArbolControl.Instance.life -= 1;
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
