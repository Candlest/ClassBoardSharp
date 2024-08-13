const WIDTH = cbsys.getWidth();
const HEIGHT = cbsys.getHeight();

document.body.style.width = WIDTH;
document.body.style.height = HEIGHT;

setInterval(setTime, 1000);
function weeksBetween(startDate, endDate) {
    // 将日期字符串转换为 Date 对象
    const start = new Date(startDate);
    const end = new Date(endDate);

    // 检查日期的有效性
    if (isNaN(start) || isNaN(end)) {
        throw new Error('Invalid date');
    }

    // 找到最近的周一
    function getMonday(date) {
        const dayOfWeek = date.getDay(); // 0: 周日, 1: 周一, ..., 6: 周六
        const diff = date.getDay() === 0 ? -6 : 1 - date.getDay();
        const monday = new Date(date);
        monday.setDate(monday.getDate() + diff);
        return monday;
    }

    // 获取起始日期和结束日期的最近的周一
    const startMonday = getMonday(start);
    const endMonday = getMonday(end);

    // 计算两个日期之间的毫秒数差值
    const diffMs = Math.abs(endMonday - startMonday);

    // 转换为天数
    const diffDays = Math.ceil(diffMs / (1000 * 60 * 60 * 24));

    // 计算周数
    const weeks = Math.ceil(diffDays / 7);

    return weeks;
}

const startDate = cbsys.getConfigFromIni("FrontEnd", "Week_Num_Begin_Date", "config/config.ini");


function setTime() {
    var date = new Date();
    var week_term = weeksBetween(startDate, date)
    document.getElementById("time-a").innerHTML = date.toLocaleTimeString('en', { hour12: true });
    document.getElementById("date-a").innerHTML = date.toLocaleDateString('zh');
    document.getElementById("week-a").innerHTML = '第' + week_term + '周';
    //document.getElementById("nav-time").insertAdjacentHTML('beforeend', '<a href="#" role="button"><h1>' +date.toLocaleTimeString('zh', { hour12: true })  + '</h1></div>');
}
