using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_anim_trigger : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Получаем компонент Animator у текущего объекта
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        // Создаем триггер
        animator.SetTrigger("touch");
    }
}