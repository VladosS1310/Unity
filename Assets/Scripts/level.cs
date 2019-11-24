using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level : MonoBehaviour {
    public static int Levels = 1; // сколько уровней будет открыто при старте игры (в данном случае 1)
    [SerializeField]
    Sprite open; // картинка открытого/пройденного уровня
    [SerializeField]
    Sprite closed; //картинка закрытого/не пройденного уровня

    void Start ()
    {
        for (int i = 0; i < transform.childCount; i++) { // узнаем, какие есть дочерние объекты у all_level + будем 
            // обращаться именно к этим элементам 
            //(т.е. перебираем их(transform.childCount) от 0(i=0) и до самтого последнего(i++)
            if (i < Levels) { // если i меньше нашего levels (в данном случае 1) , то мы делаем кнопку активной
                transform.GetChild (i).GetComponent<Image> ().sprite = open; // картинка кнопки = картинки open (выше написали ее)
                transform.GetChild (i).GetComponent<Button> ().interactable = true; // кнопка становиться активной ( реагирует на нажатие)
            } else { // иначе (если не выполняется вышенаписанное условие)
                transform.GetChild (i).GetComponent<Image> ().sprite = closed; // картинка кнопки = картинки closed (выше написали ее)
                transform.GetChild (i).GetComponent<Button> ().interactable = false; // кнопка становиться не активной 
                // (не реагирует на нажатие)
            }
        }
    }
}