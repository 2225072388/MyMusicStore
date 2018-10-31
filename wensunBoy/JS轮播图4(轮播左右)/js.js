function $(id) {
    return document.getElementById(id);
}
window.onload = function () {

    var tar = 0;
    var lea = 0;
    //鼠标悬停时箭头出现
    $("box").onmouseover = function () {
        $("arrow").style.display = "block";
    }

    $("box").onmouseout = function () {
        $("arrow").style.display = "block";
    }
    //点击只左箭头，left-520;right+520;
    $("left").onclick = function () {
        tar += 520;
    }
    $("right").onclick = function () {
        tar -= 520;
    }
    //动画把ul的left属性设置为对应在值
    setInterval(function () {
        if (tar >= 0) {
            tar = 0;
        }
        else if (tar <= -2080) {
            tar = -2080;
        }

        lea = lea + (tar - lea) / 10;
        $("ad_imgs").style.left = lea + "px";
    }, 30)
}