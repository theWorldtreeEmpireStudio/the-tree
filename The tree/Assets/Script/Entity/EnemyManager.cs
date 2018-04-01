using UnityEngine;
using System.Collections;
using System;


//游戏物体管理
public class EnemyManager: MonoBehaviour
{
	public MovingEntity[] m_enemyPrefabs;  //敌人预制物列表
	public int m_initEnemyNum = 5;   //初始生成敌人数量

	//敌人生成范围
	public Vector3 m_enemy_startPos; 
	public Vector3 m_enemy_endPos;

    double m_enemy_create_delta; //敌人生成间隔
    double m_start_enemy_time;  //开始生成敌人时间
    int m_max_crete_num;  //生成敌人的最大数量

    GameTimer m_timer = new GameTimer();

    void Start()
	{
		Init (); //初始化
	}
    //刷新时间
    private void Update()
    {
        m_timer.Update(Time.deltaTime);
    }
    //初始化
    public void Init()
	{
        var config_data = GameConfig.instance.Config_data[GameConfig.StrSystem];

        m_enemy_create_delta = Convert.ToDouble(config_data[GameConfig.StrEnemyCreateDelta].ToString());
        m_start_enemy_time = Convert.ToDouble(config_data[GameConfig.StrStartEnemyTime].ToString());
        m_max_crete_num =Convert.ToInt32(config_data[GameConfig.StrEnemyMaxCreateNum].ToString());

        WorldTimer.Instance.AddEvent("StartEnemy", m_start_enemy_time, StartEnemy);

    }

    //
    private void StartEnemy()
    {
        Debug.Log("Start Create Enemy");

        GenerateEnemys(m_max_crete_num); //先生成一次
        m_timer.AddEvent("GenerateEnemys", m_enemy_create_delta, () =>
         {
             GenerateEnemys(m_max_crete_num);
         }, TimerCallType.always, true);
    }


	//生成敌人
	//@1 敌人数量
	void GenerateEnemys(int num)
	{
		if (m_enemyPrefabs.Length == 0) {
			Debug.LogError ("敌人列表为空!");
		}
		float randNum = 0;
        num = UnityEngine.Random.Range(1, num);
        
        for (int i = 0; i < num; ++i)
        {
            //随机在指定范围内生成
            randNum = UnityEngine.Random.Range(m_enemy_startPos.x, m_enemy_endPos.x);
            MovingEntity entity = GameObject.Instantiate(m_enemyPrefabs[0],
                    new Vector3(randNum, m_enemy_startPos.y, m_enemy_startPos.z),
                    m_enemyPrefabs[0].transform.rotation) as MovingEntity;
            entity.gameObject.SetActive(true);
        }
	}

}

