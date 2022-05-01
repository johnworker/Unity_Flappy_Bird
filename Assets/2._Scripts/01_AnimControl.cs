using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    // 宣告動畫控制器
    private Animator UnityChanSelf;

    // 宣告動畫布林值：跑步、跳躍、勝利、敗北
    public bool RunBool, JumpBool, WinBool, LoseBool;

    // 初始化設定
    void Start()
    {
        // 定義動畫控制器 = UnityChan身上自帶的動畫控制器
        UnityChanSelf = this.GetComponent<Animator>();
        
    }

    // 持續執行
    void Update()
    {
        // 更新人物動畫，連結並設定動畫控制器(跑步布林參數名稱",此Script所宣告的跑步布林值)
        UnityChanSelf.SetBool("RunBool", RunBool);
        // 更新人物動畫，連結並設定動畫控制器(跳躍布林參數名稱",此Script所宣告的跳躍布林值)
        UnityChanSelf.SetBool("JumpBool", JumpBool);
        // 更新人物動畫，連結並設定動畫控制器(勝利布林參數名稱",此Script所宣告的勝利布林值)
        UnityChanSelf.SetBool("WinBool", WinBool);
        // 更新人物動畫，連結並設定動畫控制器(敗北布林參數名稱",此Script所宣告的敗北布林值)
        UnityChanSelf.SetBool("LoseBool", LoseBool);

    }
}
