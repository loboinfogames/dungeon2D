using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    [SerializeField]
    public float speed;         //velocidade de movimento, regula no Unity
    private Vector2 direction; //direção que o player vai andar
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        direction = Vector2.up;
    }
    void Update()
    {
        GetInput();  //tecla que você pressionar
        MOVE();      //executa o movimento de acordo com o IF
        
    }
    public void MOVE()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))   // pode trocar o W pelo UpArrow, anda e fica com a animação up
        {
            direction += Vector2.up;
            anim.SetBool("W", true);
            anim.SetBool("A", false);
            anim.SetBool("S", false);
            anim.SetBool("D", false);
            anim.SetBool("Parado", false);
        }
        if (Input.GetKeyUp(KeyCode.W))   //quando soltar o botão, fica só com a animação de parado ligada
        {
            anim.SetBool("W", false);
            anim.SetBool("A", false);
            anim.SetBool("S", false); //simulando a animação de parado
            anim.SetBool("D", false);
            anim.SetBool("Parado", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            anim.SetBool("W", false);
            anim.SetBool("A", false);
            anim.SetBool("S", true);
            anim.SetBool("D", false);
            anim.SetBool("Parado", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("W", false);
            anim.SetBool("A", false);
            anim.SetBool("S", false);
            anim.SetBool("D", false);
            anim.SetBool("Parado", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            anim.SetBool("W", false);
            anim.SetBool("A", true);
            anim.SetBool("S", false);
            anim.SetBool("D", false);
            anim.SetBool("Parado", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("W", false);
            anim.SetBool("A", false);
            anim.SetBool("S", false);
            anim.SetBool("D", false);
            anim.SetBool("Parado", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            anim.SetBool("W", false);
            anim.SetBool("A", false);
            anim.SetBool("S", false);
            anim.SetBool("D", true);
            anim.SetBool("Parado", false);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("W", false);
            anim.SetBool("A", false);
            anim.SetBool("S", false);
            anim.SetBool("D", false);
            anim.SetBool("Parado", true);
        }
    }
}
