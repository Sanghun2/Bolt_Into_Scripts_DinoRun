using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] Transform[] sky;
    [SerializeField] Transform[] cloud;
    [SerializeField] Transform[] mountain;
    [SerializeField] Transform[] ground;
    [SerializeField] Transform[] objection;

    [SerializeField] float skySpeed;
    [SerializeField] float cloudSpeed;
    [SerializeField] float mountainSpeed;
    [SerializeField] float groundSpeed;

    Vector3 moveVec;
    Vector3 ResetVec;

    void Start()
    {
        //매번 new를 사용하면 가비지가 생길 것을 고려해 미리 저장해두고 참조하는 방식으로 사용.
        moveVec = Vector3.left;
        ResetVec = Vector3.right * 24;
    }

    void Update()
    {
        //하늘
        foreach (var obj in sky)
        {
            obj.Translate(moveVec*skySpeed*Time.deltaTime);
            if (obj.transform.position.x < -12) RePosition(obj);
        }
        //구름
        foreach (var obj in cloud)
        {
            obj.Translate(moveVec * cloudSpeed * Time.deltaTime);
            if (obj.transform.position.x < -12) RePosition(obj);
        }
        //산
        foreach (var obj in mountain)
        {
            obj.Translate(moveVec * mountainSpeed * Time.deltaTime);
            if (obj.transform.position.x < -12) RePosition(obj);
        }
        //땅
        foreach (var obj in ground)
        {
            obj.Translate(moveVec * groundSpeed * Time.deltaTime);
            if (obj.transform.position.x < -12) RePosition(obj);
        }
        //장애물
        foreach (var obj in objection)
        {
            obj.Translate(moveVec * groundSpeed * Time.deltaTime);
            if (obj.transform.position.x < -12) RePosition(obj, Random.Range(0,3));
        }
    }

    void RePosition(Transform tr)
    {
        tr.localPosition += ResetVec;
    }
    
    //만약 장애물일 때는 랜덤으로 등장하게 만드는 기능. 재배치 함수 오버로딩 사용. by상훈_20.02.03
    void RePosition(Transform tr, int rand)
    {
        tr.localPosition += ResetVec;
        switch (rand)
        {
            case 0:
            case 1:
                tr.gameObject.SetActive(true); //66.6% 확률로 재등장
                break;
            case 2:
                tr.gameObject.SetActive(false);
                break;
            default:
                break;
        }
    }
}
