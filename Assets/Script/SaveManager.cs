using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [System.Serializable]
    public class SaveDate
    {
        public int stageFlags;
    }


    string dataPath;

    private void Awake()
    {
        //���߂ɕۑ�����v�Z����@Application.dataPath�ō��J���Ă���Unity�v���W�F�N�g��Assets�t�H���_�������w�肵�āA���ɕۑ���������
        dataPath = Path.Combine(Application.persistentDataPath, "SaveDate.json");
    }

    // JSON�`���ɃV���A���C�Y���ăZ�[�u
    public void OnSave(int stageNo)
    {
        // �V���A���C�Y����I�u�W�F�N�g���쐬
        var obj = new SaveDate
        {
            stageFlags = stageNo
        };

        // JSON�`���ɃV���A���C�Y
        var json = JsonUtility.ToJson(obj, false);

        // JSON�f�[�^���t�@�C���ɕۑ�
        File.WriteAllText(dataPath, json);
    }

    // JSON�`�������[�h���ăf�V���A���C�Y
    public int OnLoad()
    {
        // �O�̂��߃t�@�C���̑��݃`�F�b�N
        if (!File.Exists(dataPath)) return 0;

        // JSON�f�[�^�Ƃ��ăf�[�^��ǂݍ���
        var json = File.ReadAllText(dataPath);

        // JSON�`������I�u�W�F�N�g�Ƀf�V���A���C�Y
        var obj = JsonUtility.FromJson<SaveDate>(json);

        return obj.stageFlags;
    }


}