using UnityEngine;

public class GerenciadordoJogo : MonoBehaviour
{
    private int bolinhasColetadas = 0;
    private const int TOTAL_BOLINHAS = 10;
    private bool jogoVencido = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coletavel") && !jogoVencido)
        {
            Destroy(collision.gameObject);
            bolinhasColetadas++;

            Debug.Log("Bolinhas coletadas: " + bolinhasColetadas + "/" + TOTAL_BOLINHAS);

            if (bolinhasColetadas >= TOTAL_BOLINHAS)
            {
                jogoVencido = true;
                Debug.Log("Parabens!!Você venceu!");
            }
        }
    }
}
