using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVec : MonoBehaviour
{
    public GameObject target;   // 参照するゲームオブジェクト
    public string compName;     // コンポーネントの名前
    public string valueName;    // public変数名 

    [SerializeField] float firstShotPower = 2.0f; // 初回の月を打ち出すパワー
    // Start is called before the first frame update
    void Start()
    {
        // 使用しない
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 月の移動
    private void FixedUpdate()
    {
        var rabbitComp = target.GetComponent(compName);
        var vectorField = rabbitComp.GetType().GetField(valueName/*target(rabbitComp)のベクトルの変数名*/);
        Vector2 vector = (Vector2)vectorField.GetValue(rabbitComp);

        // 月の座標
        Vector2 moonPos = gameObject.transform.position;
        moonPos += vector * firstShotPower * Time.deltaTime;

        gameObject.transform.position = moonPos;
    }
}
