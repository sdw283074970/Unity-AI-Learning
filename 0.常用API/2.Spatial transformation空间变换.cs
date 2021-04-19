### 四元旋转
RTS游戏中，点击地面，物体先通过旋转转向到点击地点，再执行系统

```c#
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField]
    private NavMeshAgent agent = null;

    [SerializeField]
    private float RotateSpeed = 10f;

    private Vector3 targetPoint;
    
    [ClientCallback]
    void LateUpdate()
    {
        if (targetPoint != null)
        {
            var targetDir = targetPoint - this.transform.position;
            Debug.Log($"Angel: {Vector3.Angle(this.transform.forward, this.transform.TransformVector(targetDir))}");

            if (Vector3.Angle(this.transform.forward, targetDir) > 90)
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(targetDir), Time.deltaTime * RotateSpeed);
            else
                agent.SetDestination(targetPoint);
        }
        
        if (!hasAuthority) { return; }

        // 检测鼠标输入
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());

            // 执行碰撞检测
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                targetPoint.x = hit.point.x;
                targetPoint.z = hit.point.z;
            }
        }
    }
}
```

> 目前存在的问题，在agent移动到目标地点前无法中止指令。如果有新指令进入，只能播放完转向动画后才能前往新地点。在转向完成之前仍然会前往之前的目标地点，同时转向。
