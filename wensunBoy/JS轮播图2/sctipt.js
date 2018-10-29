window.onload = function () {
    var scroll = document.getElementById('scroll');   //取子元素;
    var ul = scroll.children[0];
    var timer = null;//定义计时器

    //用于控制控制left的变量
    var left = 0;
    var tar = 0;

    //计时器开始
    timer = setInterval(Play, 10);
    scroll.onmouseover = function () {
        clearInterval(timer);
    }
    // 计时器停止 
    scroll.onmouseout = function () {
       timer=setInterval(Play, 10);
    }

    function Play() {
        tar--;
        tar <= -1200 ? tar = 0 : tar;
        left = left + (tar - left) / 10;
        ul.style.left = left + "px";
    }
}