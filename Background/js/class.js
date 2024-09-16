var times;

// 初始化课程表
function initClass() {
    // 解析 CSV 文件获取课程安排数据
    const { schedule, dailyClassCount, times } = parseCSV();
    // 获取当前星期几，0 表示周日，1 表示周一，以此类推
    let currentDay = new Date().getDay();
    // 如果是周日 就要把currentDay改为7 防止下面的数组溢出
    if(currentDay === 0) {
        currentDay = 7
    }
    // 根据当前星期获取今天的课程安排
    const todaySchedule = schedule[currentDay - 1]; // 0-based array index
    // 获取当前正在进行的课程索引
    const currentClassIndex = getCurrentClassIndex(times);

    // 获取课程容器元素
    const container = document.getElementById('courseContainer');

    // 清空容器内的所有内容
    container.innerHTML = '';

    // 显示今天的课程
    for (let index = 0; index <= dailyClassCount; index++) {
        const item = todaySchedule[index];

        // 创建一个新的 div 元素
        const courseDiv = document.createElement('div');
        // 创建一个新的 a 元素
        const courseLink = document.createElement('a');
        // 设置链接的 href 属性
        courseLink.href = '#';
        // 设置链接的角色属性
        courseLink.role = 'button';
        // 设置链接的 CSS 类名
        courseLink.className = 'contrast';
        // 设置链接的 ID
        courseLink.id = `c_b${index}`;
        // 设置链接的文本内容
        courseLink.textContent = item;

        // 将链接添加到 div 中
        courseDiv.appendChild(courseLink);
        // 将 div 添加到容器中
        container.appendChild(courseDiv);
    }

    // 如果有当前正在进行的课程，为其添加 'current' 类
    if (currentClassIndex !== null) {
        document.getElementById(`c_b${currentClassIndex}`).classList.add('current');
    }

    // 调用 updateEverySecond 函数，每秒更新课程颜色
    updateEverySecond(times);
}

// 读取表单
function readClass() {
    // 使用 cbio 对象的 readFileToString 方法读取 CSV 文件内容
    const text = cbio.readFileToString("config/class.csv");
    // 将文本按行分割，并将每一行再按逗号分割成数组
    return text.split('\n').map(row => row.split(','));
}

// 保存表单
function parseCSV() {
    // 读取 CSV 数据
    const data = readClass();
    // 假设第一行是表头，倒数第二行是时间行
    const header = data[0];
    // 获取时间行
    const timeRow = data[data.length - 2];
    // 获取课程安排数据
    const schedule = data.slice(1, -2);

    // 打印表头、时间行和课程安排
    console.log(header, timeRow, schedule);

    // 获取每天课程的数量
    const dailyClassCount = parseInt(header[header.length - 1], 10);
    // 解析时间行，得到每个课程的时间范围
    times = timeRow.slice(1).map(time => time.split('-'));

    // 打印每天课程的数量和时间表
    console.log(dailyClassCount, times);

    // 返回解析后的课程安排数据
    return { schedule, dailyClassCount, times };
}

/**
 * 根据当前时间获取当前上课索引
 *
 * 该函数通过比较当前时间与给定的上课时间表，找出当前正在进行的课程索引
 * 如果当前时间不在任何课程的开始和结束时间内，则返回 null
 *
 * @param {Array} times - 上课时间表，每个元素是一个包含开始和结束时间的数组，格式为 ['hh:mm', 'hh:mm']
 * @returns {number|null} - 当前课程的索引，如果不在任何课程时间内则返回 null
 */
function getCurrentClassIndex(times) {
    // 创建一个当前时间对象
    const now = new Date();
    // 计算当前时间的分钟数，将小时转换为分钟
    const currentTime = now.getHours() * 60 + now.getMinutes();

    // 遍历上课时间表
    for (let i = 0; i < times.length; i++) {
        // 解构当前课程的开始和结束时间
        const [beginTime, endTime] = times[i].map(t => {
            // 将时间字符串分割为小时和分钟，并转换为整数
            const [hour, minute] = t.split(':').map(Number);
            // 将小时转换为分钟并加上分钟数
            return hour * 60 + minute;
        });

        // 判断当前时间是否在课程的开始和结束时间内
        if (currentTime >= beginTime && currentTime < endTime) {
            // 如果是，则返回当前课程的索引
            return i;
        }
    }

    // 如果当前时间不在任何课程时间内，则返回 null
    return null;
}

/**
 * 更新课程表的颜色
 *
 * 该函数用于每秒更新课程表的颜色，以反映当前时间和课程状态。
 * 已经结束的课程背景会被设置为 #3daee930 颜色，字体重量设为 450，行高设为 1。
 * 当前进行中的课程背景会被设置为 #93cee97f，字体颜色为白色，字体重量设为 600。
 *
 * @param {Array} times - 上课时间表，每个元素是一个包含开始和结束时间的数组，格式为 ['hh:mm', 'hh:mm']
 */
function updateClassColor(times) {
    console.log("updateClassColor");

    // 获取当前时间
    const now = new Date();
    // 计算当前时间的分钟数，将小时转换为分钟
    const currentTime = now.getHours() * 60 + now.getMinutes();
    console.log(currentTime);

    // 遍历上课时间表
    for (let i = 0; i < times.length; i++) {
        // 解构当前课程的开始和结束时间
        const [beginTime, endTime] = times[i].map(t => {
            // 将时间字符串分割为小时和分钟，并转换为整数
            const [hour, minute] = t.split(':').map(Number);
            // 将小时转换为分钟并加上分钟数
            return hour * 60 + minute;
        });

        // 检查当前时间是否在课程的开始和结束时间内
        console.log(currentTime, beginTime, endTime);
        // 将第一个的 周几 加亮
        document.getElementById('c_b' + 0).style.backgroundColor = '#3daee930';
        document.getElementById('c_b' + 0).style.fontWeight = '450';
        document.getElementById('c_b' + 0).style.lineHeight = '1';
        if (currentTime >= endTime) {
            // 如果是i的话 会导致课程表错位
            const j = i + 1;
            // 如果课程已经结束
            document.getElementById('c_b' + j).style.backgroundColor = '#3daee930';
            document.getElementById('c_b' + j).style.fontWeight = '450';
            document.getElementById('c_b' + j).style.lineHeight = '1';
        } else if (currentTime >= beginTime && currentTime < endTime) {
            // 如果课程正在进行中
            document.getElementById('c_b' + j).style.backgroundColor = '#93cee97f';
            document.getElementById('c_b' + j).style.color = 'white';
            document.getElementById('c_b' + j).style.fontWeight = '600';
        }
    }
}

// 定义一个函数，每秒更新课程颜色
function updateEverySecond(times) {
    // 使用 setInterval 每秒调用一次 updateClassColor 函数
    setInterval(() => {
        updateClassColor(times);
    }, 1000);
}

// 初始化课程表
initClass();
