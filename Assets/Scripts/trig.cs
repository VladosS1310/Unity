using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trig : MonoBehaviour {
	
    public string player; // публичная переменная (сторока), т.е. кто будет входить в триггер
    void OnTriggerEnter2D(Collider2D col){ // триггер, реагирует при взаимодействии с ним (при входе игрока в триггер)
        if (col.tag == player) { // если в коллайдер попал наш игрок (а именно public string player). 
            //Т.Е. игрок достиг итоговой точки данного уровня
            {
                if (SceneManager.GetActiveScene ().buildIndex == level.Levels) { // сравниваем индекс сцены с levels
                    // с цифрой в начале прошлого скрипта, и если они совподают, то 
                    level.Levels++; // добавляем единицу к нашему индексу сцены
                }
                Debug.Log ("YPA!!!");// в консоль (console) выводиться текст "ура"
                SceneManager.LoadScene (4); // загружаем сцену с индексом 5 (my_level) и в ручную переходим на следующий уровень,
                //                                                             который у нас открылся
            }
        }
        // УСЛОВИЯ ПРОИГРЫША!
        if (Input.GetKeyDown (KeyCode.P)) { // если нажата кнопка "P" на клавиатуре, то
            Debug.Log ("NO....");           // в консоль (console) выводиться текст "no..."
            SceneManager.LoadScene (4);     // загружается сцена с индексом 5, НО следующий уровень не открыт
            //                     (необходимо дойти до триггера и откроеться след. уровень)
        }

    }
}