using UnityEngine;
using UnityEngine.InputSystem; // Importa o novo sistema de input

public class MovimentacaodoJogador : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;
    private Vector2 entradaMovimento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Se o teclado atual existir no computador
        if (Keyboard.current != null)
        {
            float moverX = 0f;
            float moverY = 0f;

            // Verifica o pressionamento das teclas WASD ou Setas
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moverX = 1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moverX = -1f;
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moverY = 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moverY = -1f;

            entradaMovimento = new Vector2(moverX, moverY).normalized;
        }
    }

    void FixedUpdate()
    {
        if (rb == null) return;
        rb.linearVelocity = entradaMovimento * velocidade;
    }
}
