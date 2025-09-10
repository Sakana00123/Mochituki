using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVec : MonoBehaviour
{
    public GameObject target;   // �Q�Ƃ���Q�[���I�u�W�F�N�g
    public string compName;     // �R���|�[�l���g�̖��O
    public string valueName;    // public�ϐ��� 

    [SerializeField] float firstShotPower = 2.0f; // ����̌���ł��o���p���[
    // Start is called before the first frame update
    void Start()
    {
        // �g�p���Ȃ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ���̈ړ�
    private void FixedUpdate()
    {
        var rabbitComp = target.GetComponent(compName);
        var vectorField = rabbitComp.GetType().GetField(valueName/*target(rabbitComp)�̃x�N�g���̕ϐ���*/);
        Vector2 vector = (Vector2)vectorField.GetValue(rabbitComp);

        // ���̍��W
        Vector2 moonPos = gameObject.transform.position;
        moonPos += vector * firstShotPower * Time.deltaTime;

        gameObject.transform.position = moonPos;
    }
}
