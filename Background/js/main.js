const WIDTH = cbsys.getWidth();
const HEIGHT = cbsys.getHeight();

document.body.style.width = WIDTH;
document.body.style.height = HEIGHT;

setInterval(setTime, 1000);
//计算本年的周数
function getYearWeek(endDate) {
    //本年的第一天

    var beginDate = new Date(endDate.getFullYear(), 0, 1);
    //星期从0-6,0代表星期天，6代表星期六

    var endWeek = endDate.getDay();

    //if (endWeek == 0) endWeek = 7;

    var beginWeek = beginDate.getDay();

    if (beginWeek == 0) beginWeek = 7;
    //计算两个日期的天数差

    var millisDiff = endDate.getTime() - beginDate.getTime();
    var dayDiff = Math.floor((millisDiff + (beginWeek - endWeek) * (24 * 60 * 60 * 1000)) / 86400000);
    return Math.ceil(dayDiff / 7) + 1;
}
function setTime() {
    var date = new Date();
    var week = getYearWeek(date);
    var week_term = week - 35 + '<em>(' + (week - 31) + ')</em>';
    document.getElementById("time-a").innerHTML = date.toLocaleTimeString('en', { hour12: true });

    document.getElementById("date-a").innerHTML = date.toLocaleDateString('zh');
    document.getElementById("week-a").innerHTML = '第' + week_term + '周';
    //document.getElementById("nav-time").insertAdjacentHTML('beforeend', '<a href="#" role="button"><h1>' +date.toLocaleTimeString('zh', { hour12: true })  + '</h1></div>');
}
