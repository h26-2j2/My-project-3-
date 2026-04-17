using UnityEngine;

public class ActionFleur : MonoBehaviour
{
    void OnMouseDown()
    {
        // On cherche le gestionnaire dans la scène
        GestionnaireCouleurs gestionnaire = FindObjectOfType<GestionnaireCouleurs>();
        
        if (gestionnaire != null)
        {
            // On envoie le Tag de la fleur ET l'objet lui-même pour qu'il change de couleur
            gestionnaire.TentativeAvancement(gameObject.tag, gameObject);
        }
        else
        {
            Debug.LogError("Le script GestionnaireCouleurs est introuvable dans la scène !");
        }
    }
}