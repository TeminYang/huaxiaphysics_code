using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wudaobianhuan : MonoBehaviour
{
    // Start is called before the first frame update
    public  Animator animator;
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))//当按下空格时执行Space可以更改为键盘任意键（只要开心就好）
        {
            Animator_wudao1();//使用设置变量的方法
                            // animator.Play("002");//animator.Play("动画机名称")--该方法可以直接播放指定动画（没有过度）
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Animator_wudao2();
        }
        if (Input.GetKeyDown(KeyCode.E ))
        {
            Animator_wudao3();
        }
        if (Input.GetKeyDown(KeyCode.R ))
        {
            Animator_wudao4();
        }
        if (Input.GetKeyDown(KeyCode.T ))
        {
            Animator_wudao5();
        }
        //if (Input.GetKeyDown(KeyCode.S ))
        //{
        //    Animator_Stop();
        //}

        //StartCoroutine(DelayOneSecond());
    }
    IEnumerator DelayOneSecond()
    {
        //延迟一秒钟
       yield return new WaitForSeconds(1);

        //延迟结束后执行的代码
        Animator_Stop();
    }

    /// <summary>
    /// 设置动画机变量
    /// </summary>
    public void Animator_wudao1()
    {
        animator.SetBool("wudao1", true);//设置bool类型变量--SetBool("自己的变量名",变量的状态（true/false）)
        StartCoroutine(DelayOneSecond());//animator.SetFloat("Is_Up",1.234f);//设置Float类型变量--SetFloat("自己的变量名",触发数值)
                                                                         //animator.SetTrigger("Is_Up");//设置Trigger类型变量--animator.SetTrigger("自己的变量名");只触发一次
                                                                                                         //animator.SetInteger("Is_Up",1);//设置Int类型变量--SetInteger("自己的变量名",整数类型的数字)
    }
    public void Animator_wudao2()
    {
        animator.SetBool("wudao2", true);//设置bool类型变量--SetBool("自己的变量名",变量的状态（true/false）)
        StartCoroutine(DelayOneSecond());//animator.SetFloat("Is_Up",1.234f);//设置Float类型变量--SetFloat("自己的变量名",触发数值)
                                         //animator.SetTrigger("Is_Up");//设置Trigger类型变量--animator.SetTrigger("自己的变量名");只触发一次
                                         //animator.SetInteger("Is_Up",1);//设置Int类型变量--SetInteger("自己的变量名",整数类型的数字)
    }
    public void Animator_wudao3()
    {
        animator.SetBool("wudao3", true);//设置bool类型变量--SetBool("自己的变量名",变量的状态（true/false）)
        StartCoroutine(DelayOneSecond());//animator.SetFloat("Is_Up",1.234f);//设置Float类型变量--SetFloat("自己的变量名",触发数值)
                                         //animator.SetTrigger("Is_Up");//设置Trigger类型变量--animator.SetTrigger("自己的变量名");只触发一次
                                         //animator.SetInteger("Is_Up",1);//设置Int类型变量--SetInteger("自己的变量名",整数类型的数字)
    }
    public void Animator_wudao4()
    {
        animator.SetBool("wudao4", true);//设置bool类型变量--SetBool("自己的变量名",变量的状态（true/false）)
        StartCoroutine(DelayOneSecond());//animator.SetFloat("Is_Up",1.234f);//设置Float类型变量--SetFloat("自己的变量名",触发数值)
                                         //animator.SetTrigger("Is_Up");//设置Trigger类型变量--animator.SetTrigger("自己的变量名");只触发一次
                                         //animator.SetInteger("Is_Up",1);//设置Int类型变量--SetInteger("自己的变量名",整数类型的数字)
    }
    public void Animator_wudao5()
    {
        animator.SetBool("wudao5", true);//设置bool类型变量--SetBool("自己的变量名",变量的状态（true/false）)
        StartCoroutine(DelayOneSecond());//animator.SetFloat("Is_Up",1.234f);//设置Float类型变量--SetFloat("自己的变量名",触发数值)
                                         //animator.SetTrigger("Is_Up");//设置Trigger类型变量--animator.SetTrigger("自己的变量名");只触发一次
                                         //animator.SetInteger("Is_Up",1);//设置Int类型变量--SetInteger("自己的变量名",整数类型的数字)
    }
    //设置动画机控制变量为（false 或其他不能触发的数字即可）
    void Animator_Stop()
    {
        animator.SetBool("wudao1", false );
        animator.SetBool("wudao2", false);
        animator.SetBool("wudao3", false);
        animator.SetBool("wudao4", false);
        animator.SetBool("wudao5", false);
    }
}
