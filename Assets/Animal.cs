using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal 
    //: MonoBehaviour 
    // 유니티에서 작성하는 대부분의 스크립트는 MonoBehaviour 클래스를 상속한다!
    // 기본적으로 생성되나 MonoBehaviour new를 사용하지 않기 때문에 조심!! -> 상속한 클래스는 new로 오브젝트로 생성할 수 없기 떄문!!
{
    // 동물에 대한 변수
    public string name;
    public string sound;
    // public       : 클래스 외부에서 멤버에 접근 가능
    // private      : 클래스 내부에서만 멤버에 접근 가능
    // protected    : 클래스 내부와 파생 클래스에서만 멤버에 접근 가능
    
    // 울음소리를 재생하는 메서드
    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}
