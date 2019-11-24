using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  private GameObject parent;
  public GameObject Parent
  {
    get => parent;
    set { parent = value; }
  }

  private float speed = 10.0F;
  private Vector3 direction;
  public Vector3 Direction
  {
    set => direction = value;
  }

  public Color Color
  {
    set { sprite.color = value; }
  }

  private SpriteRenderer sprite;
 
  private void Awake()
  {
    sprite = GetComponentInChildren<SpriteRenderer>();
  }

  private void Start()
  {
    Destroy(gameObject, 2.0F);
  }

  private void FixedUpdate()
  {
    transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
  }

  private void OnTriggerEnter2D(Collider2D collider)
  {
    Unit unit = collider.GetComponent<Unit>();

    if (unit && unit.gameObject != parent)
    {
//      unit.ReceiveDamage();
      Destroy(gameObject);
    }
  }
}
