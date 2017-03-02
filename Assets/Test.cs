using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;
	private int power = 25;
	//int型の変数mpを宣言し、53で初期化してください
	private int mp = 53;



	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	
	}
		
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	//mpを消費して魔法攻撃をするMagic関数を作ってください
	public void Magic(){

		//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
		//mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした，残りは" + this.mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない");
		}
	}


}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] ary = {1,2,3,4,5};

		//配列の各要素の値を順番に表示してください
		foreach(int num in ary){
			Debug.Log(num);
		}

		//for文を使い、配列の各要素の値を逆順に表示してください
		for(int i = ary.Length-1 ; i>=0; i--){
			Debug.Log (ary [i]);
		}

		Boss lastboss = new Boss ();


		//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
		int cnt = 0;
		while (cnt < 10) {
			lastboss.Magic ();
			cnt++;
		}
		//mpが足りなくなるはず
		lastboss.Magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
