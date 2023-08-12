# Class Board Sharp

- [使用教程](http://localhost:7878/Post/classboard_2.html#%E4%BD%BF%E7%94%A8%E6%95%99%E7%A8%8B)
  - [运行程序](http://localhost:7878/Post/classboard_2.html#%E8%BF%90%E8%A1%8C%E7%A8%8B%E5%BA%8F)
  - [添加程序到开机启动项](http://localhost:7878/Post/classboard_2.html#%E6%B7%BB%E5%8A%A0%E7%A8%8B%E5%BA%8F%E5%88%B0%E5%BC%80%E6%9C%BA%E5%90%AF%E5%8A%A8%E9%A1%B9)
  - [修改页面](http://localhost:7878/Post/classboard_2.html#%E4%BF%AE%E6%94%B9%E9%A1%B5%E9%9D%A2)
    - [添加课表、倒计日、布告栏内容](http://localhost:7878/Post/classboard_2.html#%E6%B7%BB%E5%8A%A0%E8%AF%BE%E8%A1%A8%E5%80%92%E8%AE%A1%E6%97%A5%E5%B8%83%E5%91%8A%E6%A0%8F%E5%86%85%E5%AE%B9)
    - [修改背景页面](http://localhost:7878/Post/classboard_2.html#%E4%BF%AE%E6%94%B9%E8%83%8C%E6%99%AF%E9%A1%B5%E9%9D%A2)
    - [Debug](http://localhost:7878/Post/classboard_2.html#debug)
- [附录](http://localhost:7878/Post/classboard_2.html#%E9%99%84%E5%BD%95)
  - [关于技术栈的碎碎念](http://localhost:7878/Post/classboard_2.html#%E5%85%B3%E4%BA%8E%E6%8A%80%E6%9C%AF%E6%A0%88%E7%9A%84%E7%A2%8E%E7%A2%8E%E5%BF%B5)
  - [关闭冰点还原](http://localhost:7878/Post/classboard_2.html#%E5%85%B3%E9%97%AD%E5%86%B0%E7%82%B9%E8%BF%98%E5%8E%9F)

# 使用教程

项目结构：

```treeview
.
├── Background
│   ├── css
│   │   ├── custom.css
│   │   ├── pico.css
│   │   ├── pico.css.map
│   │   └── wallpaper
│   │       ├── bg1.jpg
│   │       └── bg2.jpg
│   ├── js
│   │   ├── class.js
│   │   ├── event_cal.js
│   │   ├── help.js
│   │   └── main.js
│   └── main.html
└── ClassBoard.exe
```

## 运行程序

双击运行程序`ClassBoard.exe`，即可加载`Background/main.html` 为桌面背景。

## 添加程序到开机启动项

> ⚠️ 请确认一体机是否开启冰点还原功能，如有则请在<u>征得管理员同意下</u>关闭，才能添加启动项。
> 
> 关于冰点还原的关闭，参考[关闭冰点还原](http://localhost:7878/Post/classboard_2.html#%E5%85%B3%E9%97%AD%E5%86%B0%E7%82%B9%E8%BF%98%E5%8E%9F)一节。

使用组合键win+R打开运行窗口，输入`shell:startup` 打开启动项文件夹。

可以把软件快捷方式复制到`启动项文件夹`中。

打开任务管理器选择`启动`选项卡，就可以看到我们刚刚添加的启动项。

## 修改页面

### 添加课表、倒计日、布告栏内容

在托盘中点击`setting` 按钮，或者手动打开目录`Background/js/`：

```treeview
./Background/js
├── class.js
├── event_cal.js
├── help.js
└── main.js
```

> 为尽量减少迁移成本，`class.js` 和`event_cal.js` 中`source` 和`source_cal` 与原先`kb.csv` 和`djr.csv` 一致。

| 文件           | 备注                 |
| ------------ | ------------------ |
| class.js     | 修改其中source变量内容     |
| event_cal.js | 修改其中source_cal变量内容 |
| help.js      | 修改其中source_str变量内容 |

修改以后，请在托盘中点击`restart` 按钮重载应用。

### 修改背景页面

相信你也觉得此背景页不尽人意，那么请你发挥你的美学素养，以及HTML/JS/CSS相关知识修改静态网页`Background/main.html` 吧~

### Debug

ClassBoard.exe 部分采用 Dotnet4.7 + CefSharp 编写，因其~~简洁~~简陋的原因，不太可能会出Bug。

Background/ 部分采用 HTML/JS/CSS 编写，由着前端能跑就行，从不`panic` 的习惯，如果页面的渲染出现了一些奇奇怪怪的Bug，建议使用Chrome的开发者模式 Debug 。

也可以在此项目下提出`issue`：[Candlest/ClassBoard](https://github.com/Candlest/ClassBoard)

# 附录

## 关于技术栈的碎碎念

Class Board 的新版本最大的优点是抛弃了 Qt/C++ 传统的桌面设计，采用 HTML/JS/CSS 构建页面。

此版本最大的缺点也是抛弃了 Qt/C++ 传统的桌面设计，采用 HTML/JS/CSS 构建页面。

粗略地概括：

- 坏处：软件大了（50MB → 225MB），占用大了（Win GDT → Chromium Blink）
- 好处：方便维护了（甚至可以动手改完热重载），写出“稍微能看”的页面容易了

从可拓展性和易维护性来说，HTML/JS/CSS > Qt/C++ ，大概。

## 关闭冰点还原

> ⚠️ 建议备份相关文件

要删除冰点还原，需要在PE环境（或者安全模式）下，删除以下文件：

- `C:\Program Files (x86)\Seewo\SeewoService\SeewoService_1.3.6.3254` 里的`SeewoFreeze`
- `C:\ProgramData` 里的文件夹`SeewoFreeze`， `SeewoFreezeConfig` 和 `SeewoFreezeKernelConfig`
- `C:\ProgramData\Seewo` 里的`Freeze`

如果想恢复冰点，可以重新安装 Seewo 管家。
