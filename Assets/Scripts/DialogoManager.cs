using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoManager : MonoBehaviour
{

    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI TextoDelDialogo;


    [SerializeField] TextMeshProUGUI textoboton;
    [SerializeField] string[] frasesdialogo;
    [SerializeField] int posicionfrase;

    [SerializeField] bool hasTalked;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("NPC"))
        {

            if (hasTalked)
            {

                TextoDelDialogo.text = "¿Se te ofrece pollo?";
             
            }
            else
            {
                TextoDelDialogo.text = "Ya hablamos flaco";
                dialogueUI.SetActive(true);
                textoboton.text = "Cerrar";
            }
           
        }

        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
    }


    public void NextFrase()
    {

        if (posicionfrase < frasesdialogo.Length)
        {
            TextoDelDialogo.text = frasesdialogo[posicionfrase];
            posicionfrase++;

            if (posicionfrase == frasesdialogo.Length -1)
            {
                textoboton.text = "Cerrar";
            }
        }
        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }
       
    }






}


