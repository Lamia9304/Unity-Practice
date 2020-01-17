using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private Animation anim;

    private AnimationClip clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // anim.Play("Cube_2");

            // 재생중이던 애니메이션 종료후 실행
            // anim.PlayQueued("Cube_2"); 

            //두개를 섞어서 재생
            anim.Blend("Cube_2");

            //자연스럽게 교체
            // anim.CrossFade("Cube_2");

            //Cube_2가 실행중이 아니라면 2를 실행

            //if (!anim.isPlaying("Cube_2"))
            //{
            //    anim.Play("Cube_2");
            //}

            // 재생중이던 애니메이션 정지
            //anim.Stop();

            //wrap mode 변경(Once,Clamp,Clamp Forever,Loop,PingPong)


            // anim.wrapMode = WrapMode.Once;

            //애니메이션 클립 삽입

            //anim.clip=clip;
        }

    }
}
