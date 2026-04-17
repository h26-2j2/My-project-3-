using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireMenu : MonoBehaviour
{
    public void DemarrerJeu() 
    {
        // On force le jeu à "se réveiller" au cas où il serait en pause
        Time.timeScale = 1f; 
        
        // On charge le niveau 1
        SceneManager.LoadScene(1);
    }
}
