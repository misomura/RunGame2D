using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    public GameObject target;   // ’Ç]‚·‚é‘ÎÛ
    Vector3 beginPos;           // ƒJƒƒ‰‚Ì‰ŠúˆÊ’u

    // Start is called before the first frame update
    void Start()
    {
        beginPos = Camera.main.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = target.transform.position;

        if ( target.transform.position.x < 0 ) {
            cameraPos.x = 0;
        }

        if ( target.transform.position.y < 0 ) {
            cameraPos.y = 0;
        }

        if ( target.transform.position.y > 0 ) {
            cameraPos.y = target.transform.position.y;
        }

        cameraPos.z = -10;
        Camera.main.gameObject.transform.position = cameraPos;
    }
}
