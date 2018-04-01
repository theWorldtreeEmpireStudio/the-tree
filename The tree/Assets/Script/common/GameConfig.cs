using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Text;

public class GameConfig {
    public static GameConfig instance = new GameConfig();

    JsonData config_data = null;

    //公用字符串

    //系统设置
    public static string StrSystem = "System";
    public static string StrGameSpeed = "GameSpeed";
    public static string StrEnemyCreateDelta = "EnemyCreateDelta";
    public static string StrStartEnemyTime = "StartEnemyTime";
    public static string StrEnemyMaxCreateNum = "EnemyMaxCreateNum";

    public JsonData Config_data
    {
        get
        {
            if(config_data == null)
            {
                Init();
            }
            return config_data;
        }

        set
        {
            config_data = value;
        }
    }

    void Init()
    {
        FileStream fs = new FileStream(@"config.json", FileMode.Open);//初始化文件流
        byte[] array = new byte[fs.Length];//初始化字节数组
        fs.Read(array, 0, array.Length);//读取流中数据到字节数组中
        fs.Close();//关闭流
        string str = Encoding.Default.GetString(array);//将字节数组转化为字符串

        Config_data = JsonMapper.ToObject(str);
        Debug.Log(str);
    }

}
