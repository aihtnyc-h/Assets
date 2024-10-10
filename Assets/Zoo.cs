using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        // 새로운 오브젝트(인스턴스 탄생!)
        Animal tom = new Animal(); 
        // tom 이라는 오브젝트에 name, sound, PlaySound를 할당한다!
        tom.name = "톰";
        tom.sound = "냐옹!";

        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍";
        
        // tom에 할당된 Animal 오브젝트의 PlaySound() 메서드를 점 연자로 접근하고 실행!
        tom.PlaySound();
        jerry.PlaySound();
    }
}
