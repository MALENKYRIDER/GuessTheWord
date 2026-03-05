using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    private SpriteRenderer _renderer;
    
    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"OnTriggerEnter2D {other.gameObject.name}");
        
        
        // other.GetComponent,SpriteRenderer>();
        
        if (other.TryGetComponent(out SpriteRenderer enemyRenderer))
        {
            enemyRenderer.color = Color.green;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _renderer.color = Color.white;
        
        Debug.Log($"OnTriggerExit2D {other.gameObject.name}");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log($"OnTriggerStay2D {other.gameObject.name}");
    }
}