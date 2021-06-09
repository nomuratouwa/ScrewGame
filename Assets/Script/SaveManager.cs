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
        //初めに保存先を計算する　Application.dataPathで今開いているUnityプロジェクトのAssetsフォルダ直下を指定して、後ろに保存名を書く
        dataPath = Path.Combine(Application.persistentDataPath, "SaveDate.json");
    }

    // JSON形式にシリアライズしてセーブ
    public void OnSave(int stageNo)
    {
        // シリアライズするオブジェクトを作成
        var obj = new SaveDate
        {
            stageFlags = stageNo
        };

        // JSON形式にシリアライズ
        var json = JsonUtility.ToJson(obj, false);

        // JSONデータをファイルに保存
        File.WriteAllText(dataPath, json);
    }

    // JSON形式をロードしてデシリアライズ
    public int OnLoad()
    {
        // 念のためファイルの存在チェック
        if (!File.Exists(dataPath)) return 0;

        // JSONデータとしてデータを読み込む
        var json = File.ReadAllText(dataPath);

        // JSON形式からオブジェクトにデシリアライズ
        var obj = JsonUtility.FromJson<SaveDate>(json);

        return obj.stageFlags;
    }


}