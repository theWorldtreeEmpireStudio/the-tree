using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum TimerCallType
{
    one,  //只触发一次
    always //总是触发
}

class TimerEvent
{
    public double delta_time;  //触发时间间隔
    public Action time_event;  //触发事件
    public double time_counter;  //计时器
    public TimerCallType event_type;  //触发类型
    public bool is_world_speed;   //是否使用游戏时间速度
    public TimerEvent(double del_t, Action call_back, TimerCallType type, bool use_world_speed)
    {
        delta_time = del_t;
        time_event = call_back;
        time_counter = 0;
        event_type = type;
        is_world_speed = use_world_speed;
    }
}

public class GameTimer
{
    Dictionary<string, TimerEvent> m_event_dic = new Dictionary<string, TimerEvent>();
    Queue<string> m_delete_list = new Queue<string>();

    /// <summary>
    /// 添加时间回调事件
    /// </summary>
    /// <param name="event_name">事件名字</param>
    /// <param name="delta_time">触发时间间隔</param>
    /// <param name="call_back">事件函数</param>
    /// <param name="type">触发类型，只触发一次还是不断触发</param>
    /// <param name="use_world_speed">是否使用游戏速度</param>
    public void AddEvent(string event_name, double delta_time, Action call_back, TimerCallType type, bool use_world_speed)
    {
        if (call_back == null) return;
        TimerEvent ev = new TimerEvent(delta_time, call_back, type, use_world_speed);
        m_event_dic[event_name] = ev;
    }

    //移除事件
    public void RemoveEvent(string event_name)
    {
        m_event_dic.Remove(event_name);
    }


    //更新
    public void Update(double delta_time)
    {
        double factor = 1.0;
        foreach (KeyValuePair<string, TimerEvent> kvp in m_event_dic)
        {
            TimerEvent ev = kvp.Value;

            factor = 1.0f;
            if (ev.is_world_speed)
            {
                factor = WorldTimer.Instance.GameSpeed;
            }
            ev.time_counter += delta_time * factor;
            if (ev.time_counter >= ev.delta_time)
            {
                ev.time_counter = 0;
                ev.time_event();
                if (ev.event_type == TimerCallType.one)
                {
                    m_delete_list.Enqueue(kvp.Key);
                }
            }
        }

        while (m_delete_list.Count > 0)
        {
            string key = m_delete_list.Dequeue();
            m_event_dic.Remove(key);
        }

    }

}
