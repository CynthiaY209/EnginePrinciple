第二周-3C框架Demo-岳苡萱
=
* 内含：exe文件、工程源码
* 你是一个逃跑的轮胎！你越跑越快，一定要在马路上躲避障碍，别忘了收集你的金币！努力跑得更远吧！

## 框架说明
### Character
* 轮胎有正常跑、跳跃、滑行等动作，对应Idle、Run、Jump、Slide四种动画
* 轮胎运动速度会逐渐加快
* 轮胎可以吃金币，增加金币收集数量
* 撞到路障会触发Game Over
### Controller
* 键盘WASD/↑↓←→键控制左右移动或跳跃、下蹲，也可鼠标↑↓←→拖拽控制，移动端可↑↓←→触屏滑动控制
* UI界面：初始界面可进入游戏/退出游戏，Game Over界面可Restart/退出游戏
* ESC退出游戏
### Camera
* 相机跟随玩家前进
* 玩家↑↓←→移动时，相机不跟随
## 其他功能
* 编写shader，使马路产生弯曲效果
* 编写天空盒旋转脚本，使场景更美观
