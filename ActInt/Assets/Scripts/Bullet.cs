using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const float MAX_LIFE_TIME = 1f;
    private float _lifeTime = 0f;
    public Vector2 Velocity;
    public bool IsGrowing;

    private void Update(){
        if (IsGrowing){
            transform.localScale += Vector3.one * (Time.deltaTime / 5);
        }
        transform.position += (Vector3)Velocity * Time.deltaTime;
        _lifeTime += Time.deltaTime;

        if(_lifeTime > MAX_LIFE_TIME){
            Disable();
        }
    }

    private void Disable(){
        _lifeTime = 0f;
        gameObject.SetActive(false);
    }
}
