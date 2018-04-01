using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class WorldTimerEvent
{
    public double start_time; //开始时间
    public Action time_event;  //触发事件

    public WorldTimerEvent(double start_t, Action call_back)
    {
        time_event = call_back;
        start_time = start_t;
    }
}

class WorldTimer : MonoBehaviour
{
    public static WorldTimer Instance;

    public double GameSeconds; //经过秒数
    public double GameSpeed;  //游戏速度
    Dictionary<string, WorldTimerEvent> m_event_dic = new Dictionary<string, WorldTimerEvent>();
    Queue<string> m_delete_list = new Queue<string>();

    private void Awake()
    {
        Init();
    }

    private void Update()
    {
        Update(Time.deltaTime);
    }


    public void Init()
    {
        var config_data = GameConfig.instance.Config_data[GameConfig.StrSystem];

        GameSeconds = 0;
        GameSpeed = Convert.ToDouble(config_data[GameConfig.StrGameSpeed].ToString());
        Instance = this;
    }

    public void AddEvent(string event_name, double start_time, Action call_back)
    {
        Debug.Log("add world event : " + event_name);
        if (call_back == null) return;
        WorldTimerEvent ev = new WorldTimerEvent(start_time, call_back);
        m_event_dic[event_name] = ev;
    }

    public void Update(float timeDelta)
    {
        GameSeconds += timeDelta * GameSpeed;

        foreach (KeyValuePair<string, WorldTimerEvent> kvp in m_event_dic)
        {
            WorldTimerEvent ev = kvp.Value;

            if (ev.start_time <= GameSeconds)
            {
                ev.time_event();
                m_delete_list.Enqueue(kvp.Key);
            }
        }

        while (m_delete_list.Count > 0)
        {
            string key = m_delete_list.Dequeue();
            m_event_dic.Remove(key);
        }
    }
}

