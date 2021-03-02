# 笔记简述 Introduction
这是一部学习如何在`Unity3D中`实现AI行为的学习笔记。学习前置条件为：

1. 扎实的`.NET`知识
2. 扎实的`C#`编程功底
3. 对`Unity3D`有过系统性的学习

通过学习这部分教程，可以：

1. 学会通过`C#`脚本，为`Unity3D`中的对象`agent`赋予`人工智能（智障）`
2. 学会底层的AI行为逻辑
3. 学会`agent`的移动原理
4. 学会使用`Unity`中的`NavMesh`系统，以此快速实现`agent`的移动
5. 学会一些基本的AI行为（如寻求`seek`、逃跑`flee`、追逐`pursuit`、游荡`wander`、躲藏`hide`等）
6. 学会使用一个管理脚本`Manager`控制一群`agent`的行为（群体模式`flocking`）
7. 学会将有限状态机`Finite State Machines`(简称`FSM`)应用到`agent`
8. 学会使用行为树`Behaviour Tree`（简称`BT`）实现`agent`的AI控制
9. 学会使用基本的目标导向行为计划系统`Goal-oriented Action Planning`（简称`GOAP`）实现`agent`的AI控制

# Introduction

This is a study note for learning how to implement AI behavior in `unity3d`. The preconditions are as follows

1. Solid `.Net` knowledge

2. Solid `C#` programming skills

3. Have studied `unity3d` systematically

By learning this part of the tutorial, you can:

1. Learn to endow the object `agent` in `unity3d` with artificial intelligence (retard) through `C#` script

2. Learn the underlying AI behavior logic

3. Learn the mobile principle of `agent`

4. Learn to use the `NavMesh` system in unity, so as to quickly implement the mobile agent

5. Learn some basic AI behaviors (such as seeking, fleeing, pursuing, wandering, hiding, etc.)

6. Learn to use a single management script `manager` to control the behavior of a group of `agents`

7. Learn to apply `Finite State Machines(FSM)` to `agent`

8. Learn to use `Behavior Tree(BT)` to implement AI control of `agent`

9. Learn to use `Goal-oriented Action Planning(GOAP)` to control `agent` AI
