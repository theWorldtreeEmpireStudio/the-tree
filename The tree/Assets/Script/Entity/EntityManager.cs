using UnityEngine;
using System.Collections;


//游戏物体管理
public class EntityManager : MonoBehaviour
{
	public MovingEntity[] m_enemyPrefabs;  //敌人预制物列表
	public int m_initEnemyNum = 5;   //初始生成敌人数量

	//敌人生成范围
	public Vector3 m_enemy_startPos; 
	public Vector3 m_enemy_endPos;


	void Start()
	{
		Init (); //初始化
	}

	//初始化
	public void Init()
	{
		InitTree (); 
		InitEnemy (); 
	}

	//初始化敌人
	void InitEnemy()
	{
		GenerateEnemys (m_initEnemyNum);
	}

	//初始化树
	void InitTree()
	{
	}

	//生成敌人
	//@1 敌人数量
	void GenerateEnemys(int num)
	{
		if (m_enemyPrefabs.Length == 0) {
			Debug.LogError ("敌人列表为空!");
		}
		float randNum = 0;
		for (int i = 0; i < num; ++i) {
			//随机在指定范围内生成
			randNum = Random.Range (m_enemy_startPos.x, m_enemy_endPos.x);
			MovingEntity entity = GameObject.Instantiate (m_enemyPrefabs [0],
				                      new Vector3 (randNum, m_enemy_startPos.y, m_enemy_startPos.z),
				m_enemyPrefabs[0].transform.rotation) as MovingEntity;
			entity.enabled = true;
		}
	}

	//初始化其它
	//...
}

