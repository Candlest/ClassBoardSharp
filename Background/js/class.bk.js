/*课表 */

const source = cbio.readFileToString("config/class.csv");
const data = text.split('\n').map(row => row.split(','));
console.log(data);

// 假设第一行是表头，最后一行是时间行
const header = data[0];
const timeRow = data[data.length - 1];
const schedule = data.slice(1, -1);

const dailyClassCount = parseInt(header[header.length - 1], 10);
const times = timeRow.slice(1).map(time => time.split('-'));

const date = new Date();
const week = date.getDay(); //星期几

function getCurrentClassIndex(times) {
    const now = new Date();
    const currentTime = now.getHours() * 60 + now.getMinutes();

    for (let i = 0; i < times.length; i++) {
        const [beginTime, endTime] = times[i].map(t => {
            const [hour, minute] = t.split(':').map(Number);
            return hour * 60 + minute;
        });

        if (currentTime >= beginTime && currentTime < endTime) {
            return i;
        }
    }

    return null;
}
function nowClass() {

    console.log(it);
    document.getElementById('c_b' + it).style.backgroundColor = colorize ? '#93cee97f' : '#3daee930';
    document.getElementById('c_b' + it).style.color = 'white';
    document.getElementById('c_b' + it).style.fontWeight = colorize ? '600' : '400';
    for (let index = 0; index < it; index++) {
        document.getElementById('c_b' + index).style.backgroundColor = '#3daee930';
        document.getElementById('c_b' + index).style.fontWeight = '450'
        document.getElementById('c_b' + it).style.lineHeight = '1';
    }
}

nowClass()


setInterval(nowClass, 1000);