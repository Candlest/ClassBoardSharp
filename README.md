<div align="center">
  <img src="./Resources/icon.ico" alt="" width=320>
  <p><strong>ClassBoard 是一款高自由度的，用于显示教学信息的壁纸软件，功能包括高考倒计时、公告栏、以及能够提示当前课程的课程表</strong></p></div>

![](https://img.shields.io/badge/.NET_Framework-@4.6.1-green.svg?logo=dotnet) [![](https://img.shields.io/badge/Web_DEMO-@Candlest/ClassBoard_F8-red.svg?logo=githubpages)](https://candlest.github.io/ClassBoard-F8/)

- [概览](#概览)
  - [前世今生](#前世今生)
- [运行演示](#运行演示)
- [使用教程](#使用教程)
  - [获取程序](#获取程序)
  - [运行程序](#运行程序)
- [配置教程](#配置教程)
  - [修改页面](#修改页面)
    - [添加课表、倒计日、布告栏内容](#添加课表倒计日布告栏内容)
    - [修改背景页面](#修改背景页面)
  - [添加程序到开机启动项](#添加程序到开机启动项)
    - [设置开机自启动](#设置开机自启动)
    - [关闭开机自启动](#关闭开机自启动)
    - [遇到Bug的解决方案](#遇到bug的解决方案)
      - [后端 Bug](#后端-bug)
      - [前端 Bug](#前端-bug)
- [附录](#附录)
  - [关闭冰点还原](#关闭冰点还原)
  - [config.ini](#configini)
- [相关 Efforts](#相关-efforts)
- [贡献者](#贡献者)
- [License](#license)


<small><i><a href='http://ecotrust-canada.github.io/markdown-toc/'>Table of contents generated with markdown-toc</a></i></small>


## 概览

ClassBoard 以兼容性为核心（支持希沃老设备），兼顾自由性和可用性（自定义程度高，但是能够做到开箱即用），力求成为一款易用且好用的一体机壁纸软件。


### 前世今生

ClassBoardSharp 是 [ClassBoard](https://github.com/Candlest/ClassBoard) 的二代版本。

ClassBoardSharp相对 ClassBoard 一代的缺点：

- 软件**大**了（50MB → 225MB）；
- 占用**大**了（Win GDT → Chromium Blink）；
- 启动**慢**了（在希沃 H84 开机实测中：无感知地开机启动 → 需要3-5s才能将页面加载完毕）

ClassBoardSharp相对 ClassBoard 一代的优点，是采用 HTML/JS/CSS 构建页面：

- 页面可**几乎完全定制**
- 页面可**随时修改**
- 更**方便**、更**自由**地写出更好看的页面

## 运行演示

在Windows上的运行截图：
![breeze](./README/theme_breeze.png)

在浏览器中预览：https://candlest.github.io/ClassBoard-F8/
![Web_demo](./README/Web_demo.png)

实机演示：
CEFSharp 版本
![cef-ver](./README/cefsharp-version.jpg)
![cef-far](./README/far.png)
Qt 版本
![qt-ver](./README/qt-version.jpg)

---

## 使用教程

### 获取程序

从 GitHub 的 [Release 页面](https://github.com/Candlest/ClassBoardSharp/releases) 下载

国内地址：

城通网盘： <a href="https://url97.ctfile.com/f/18976897-1341252272-030e49?p=2484" target="_blank">ClassBoard_1.0.24.0813_x86.7z</a>（访问密码：2484）<br/>

### 运行程序

解压压缩包至文件夹。

双击运行程序 `ClassBoard.exe` 即可。

## 配置教程

项目结构：

```treeview
.
├── Background
├── README
├── Config
├── ...
└── ClassBoard.exe
```

|文件夹|内容|
|-----|----|
|Background|壁纸前端网页|
|Config|配置文件|

### 修改页面

#### 添加课表、倒计日、布告栏内容

在托盘中点击`设置`按钮进入设置界面，或者手动修改下面的文件：

| 文件       | 内容                                                         |
| ---------- | ------------------------------------------------------------ |
| board.txt  | 使用 html 语法，对应着右下的告示栏                           |
| events.txt | 倒计日，每行按照`事件,日期`的格式书写（本质上是个字符串数组，请不要忘记元素间的逗号） |
| class.csv  | 第一行为表头，最后一行为每节课的时间（`mm:ss-mm:ss`格式），中间为课表 |

修改以后，请在托盘中点击`重载`按钮重载应用。

#### 修改背景页面

和修改网页一样哦。

### 添加程序到开机启动项

> [!WARNING]  
> 请确认一体机是否开启冰点还原功能，如有则请在<u>征得管理员同意下</u>关闭，才能添加启动项。作者不负任何责任。
> 
> 关于冰点还原的关闭，参考[关闭冰点还原](#关闭冰点还原)一节。

#### 设置开机自启动

第一步：输入`Win+R`，键入`shell:startup`，然后选择“确定”即可打开“启动”文件夹。

第二步：将该ClassBoard的快捷方式粘贴到“启动”文件夹中即可。

#### 关闭开机自启动

第一步： 按下“打开启动项文件夹“按钮； 

第二步：在启动项文件夹中删除本程序的快捷方式；

打开任务管理器选择`启动`选项卡或者运行`msconfig`，可以看到我们刚刚添加的启动项。

#### 遇到Bug的解决方案

收集错误信息，在此项目下提出`issue`：[Candlest/ClassBoardSharp](https://github.com/Candlest/ClassBoardSharp/issues) 。

##### 后端 Bug

ClassBoardSharp 采用 C# .NET Framework 4.6.1 + CefSharp 编写，如遇错误请复制 .NET Framework 的报错信息，以及系统版本。

##### 前端 Bug

如果您有一定 Web 开发基础，可以在程序运行时打开 http://localhost:14241/ 调试代码

Debug 端口可以在 `Config/config.ini` 或者设置页面修改：

```ini
[CEF]
RemoteDebuggingPort=14241
```

## 附录

### 关闭冰点还原

> [!WARNING]  
> 建议备份相关文件

要删除冰点还原，需要在PE环境（或者安全模式）下，删除以下文件：

- `C:\Program Files (x86)\Seewo\SeewoService\SeewoService_1.3.6.3254`里的`SeewoFreeze`
- `C:\ProgramData`里的文件夹`SeewoFreeze`， `SeewoFreezeConfig` 和 `SeewoFreezeKernelConfig`
- `C:\ProgramData\Seewo`里的`Freeze`

如果想恢复冰点，可以重新安装 Seewo 管家。

### config.ini

目前已有属性：

```ini
[Window]
AsBackground=true # 是否设为桌面背景
BackgroundUrl="/Background/index.html" # 背景网页位置
QuietLoad=true # 启动时不显示气泡
[CEF]
DisableGPU=true # 关闭GPU渲染，详见issue #7
LogSeverity=4 # CEF日志级别，4为只记录error
RemoteDebuggingPort=14241 # 调试端口
[Fix_Task_View] # 修复 Task View，详见issue #5
Timer=true # Win7 可以关了
Interval=100
```

## 相关 Efforts

本项目是对前辈 ClassTool 的拙劣模仿。 ClassTool 使用 Electron + Vue.JS 构建。

> #### [ClassTool](https://github.com/IcariaWorks/ClassTools)
> 
> 一个用在班级电脑上面的动态壁纸系统，显示高考倒计时、作业、课程表、值日生等

非常感谢 CefSharp 提供平滑的 .NET + CEF 开发体验。

> #### [CefSharp](https://github.com/cefsharp/CefSharp)
> 
> .NET (WPF and Windows Forms) bindings for the Chromium Embedded Framework

## 贡献者

感谢参与测试、提供修改建议，参与代码修改的八班九班同学！

尤其是 [@Candlest](https://github.com/Candlest) 和 [@mike-unk](https://github.com/mike-unk) 以及 [@E7G](https://github.com/e7g) 同学！

Github贡献者名单：

<a herf="https://github.com/Candlest/ClassBoardSharp/graphs/contributors"><img src="https://contrib.rocks/image?repo=Candlest/ClassBoardSharp" alt="Contributors" /></a>

欢迎任何的贡献！

## License

本项目使用 **MIT License** 开源。
