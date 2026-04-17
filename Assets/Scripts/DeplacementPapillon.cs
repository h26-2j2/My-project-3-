using UnityEngine;
using UnityEngine.SceneManagement;

public class DeplacementPapillon : MonoBehaviour
{
    public float vitesse = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(moveX, moveY, 0) * vitesse * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Arrivee"))
        {
            // On cherche le gestionnaire pour savoir si on a fini les fleurs
            GestionnaireCouleurs gc = FindObjectOfType<GestionnaireCouleurs>();

            if (gc != null && gc.peutFinirNiveau == true)
            {
                Debug.Log("VICTOIRE !");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                Debug.Log("Pas si vite ! Tu dois d'abord réveiller toutes les fleurs !");
            }
        }
    }
}