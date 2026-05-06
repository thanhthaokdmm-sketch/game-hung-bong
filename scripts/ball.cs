using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android.LowLevel;

public class ball : MonoBehaviour
{
    GameController m_gc;

    private void Start()
    {
                m_gc = FindObjectOfType<GameController>();
    }

    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            Destroy(gameObject);
            Debug.Log("chạm");
        }
    }


        private void OnTriggerEnter2D(Collider2D col){
           
             if (col.CompareTag("DeathZone")){
            m_gc.SetGameOverState(true);
            Destroy(gameObject);
            Debug.Log("over");
            }
        }
    }

