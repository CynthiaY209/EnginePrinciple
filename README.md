# 第九周-游戏音频编辑

#### 2020214430 岳苡萱

## 内含文件：

 + Unity版本：2019.4.10
  
 + 可执行文件1个：exe
 
 + Unity工程1个：UnityAssignTest
 
 + Wwise工程1个：AssignTest
 
 + 音效素材包1个：AudioPackage
 
## 作业内容：

 + 基础音效
 
     + 马里奥跳跃
 
 + 随机音效
 
     + 上楼的脚步声，容器内有4个不同音频
 
 + 序列音效
 
     + 皮卡丘攻击音效，容器内有3个不同音频
     
     + 顺序为：皮卡丘生气语音 → 放电攻击音效 → 皮卡丘获胜开心语音
 
 + 混合音效
 
     + 选取森林夜间与早上音频混合，表现森林夜晚与清晨交替时刻
     
     + 森林夜晚的蛐蛐、猫头鹰叫声，混合森林清晨的鸟儿鸣叫
     
     + 交叠范围设为40-60，从小到大为夜晚到清晨，参数缺省设55，昏晨交替
     
 + 空间音效
 
     + 狙击枪音效，容器内有3个不同音频
     
     + 设置ShortGun音效连续且循环播放
     
 + UI
 
     + 2D音效分别有开关btn
     
     + 空间音效：Cube上持续播放，不关闭；btn用于单独播放和关闭射击音效（由于射击开了Loop，所以要按off btn才能停止UI上的播放）
