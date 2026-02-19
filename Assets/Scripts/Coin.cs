using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin") == true)
        {
            Debug.Log("µ¿Àü È¹µæ!");

            Destroy(gameObject);
        }
    }
}
